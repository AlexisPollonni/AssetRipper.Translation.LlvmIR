using AsmResolver.DotNet;
using AsmResolver.DotNet.Signatures;
using AsmResolver.PE.DotNet.Metadata.Tables;
using LibObjectFile.Dwarf;
using LLVMSharp.Interop;

namespace AssetRipper.Translation.LlvmIR;

/// <summary>
/// Resolves LLVM DWARF debug-type metadata nodes to .NET <see cref="TypeSignature"/> instances,
/// using a pre-built lookup table of known struct and enum identifiers.
/// </summary>
internal static class DwarfTypeResolver
{
	/// <summary>
	/// Attempts to resolve a DWARF type metadata node to a .NET <see cref="TypeSignature"/>.
	/// Returns <see langword="null"/> when the type cannot be resolved (e.g. <c>void*</c>,
	/// primitive integers, or struct/enum types that are not in the lookup).
	/// </summary>
	/// <param name="typeRef">The DWARF type metadata node to resolve.</param>
	/// <param name="lookup">
	/// Map from DWARF mangled identifier (e.g. <c>_ZTSN...E</c>) to the corresponding
	/// <see cref="TypeSignature"/> (struct or enum).
	/// </param>
	/// <param name="depth">Recursion depth guard (max 10).</param>
	internal static TypeSignature? TryResolve(
		LLVMMetadataRef typeRef,
		IReadOnlyDictionary<string, TypeSignature> lookup,
		int depth = 0
	)
	{
		if (typeRef.Handle == IntPtr.Zero || depth > 10)
			return null;

		DwarfTag tag = (DwarfTag)typeRef.Tag;

		// Transparent wrappers — pass through to base type
		if (
			tag
			is DwarfTag.Typedef
				or DwarfTag.ConstType
				or DwarfTag.VolatileType
				or DwarfTag.RestrictType
				or DwarfTag.AtomicType
		)
		{
			LLVMMetadataRef baseType = typeRef.BaseType;
			return baseType.Handle == IntPtr.Zero ? null : TryResolve(baseType, lookup, depth + 1);
		}

		// Pointer / reference types — resolve the pointee and wrap in a pointer type
		if (tag is DwarfTag.PointerType or DwarfTag.ReferenceType or DwarfTag.RvalueReferenceType)
		{
			LLVMMetadataRef baseType = typeRef.BaseType;
			if (baseType.Handle == IntPtr.Zero)
				return null; // void* — leave as-is

			TypeSignature? resolved = TryResolve(baseType, lookup, depth + 1);
			return resolved is null ? null : new PointerTypeSignature(resolved);
		}

		// Composite types (struct / class / union / enum) — look up by DWARF mangled identifier
		if (typeRef.IsADICompositeType != default)
		{
			string id = typeRef.Identifier;
			if (!string.IsNullOrEmpty(id) && lookup.TryGetValue(id, out TypeSignature? sig))
				return sig;

			return null;
		}

		return null;
	}

	/// <summary>
	/// Returns <see langword="true"/> when replacing <paramref name="currentType"/> with
	/// <paramref name="newType"/> is safe for CIL method bodies generated against
	/// <paramref name="currentType"/>. Two classes of replacement are considered safe:
	/// <list type="bullet">
	///   <item>pointer → pointer (e.g. <c>void*</c> → <c>WriteBuffer*</c>): all pointers
	///         have the same 8-byte representation on 64-bit targets.</item>
	///   <item>primitive integer → enum with the same underlying element type
	///         (e.g. <c>int</c> → <c>WriteMode : int</c>): enums and their underlying
	///         integers are interchangeable at the CIL level.</item>
	/// </list>
	/// Everything else (struct replacing integer, etc.) is blocked because the existing
	/// CIL body was generated for the original type and the two are not size-compatible.
	/// </summary>
	internal static bool IsSafeReplacement(TypeSignature currentType, TypeSignature newType)
	{
		// pointer → pointer (void* → SomeStruct*, SomeStruct* → SomeOtherStruct*)
		if (currentType is PointerTypeSignature && newType is PointerTypeSignature)
			return true;

		// integer → same-size enum
		if (
			currentType is CorLibTypeSignature { ElementType: var elemType } currentCorLib
			&& IsIntegerElement(elemType)
		)
		{
			if (newType is TypeDefOrRefSignature tdr && IsEnumTypeSignature(tdr, elemType))
				return true;
		}

		return false;
	}

	private static bool IsIntegerElement(ElementType e) =>
		e
			is ElementType.I1
				or ElementType.U1
				or ElementType.I2
				or ElementType.U2
				or ElementType.I4
				or ElementType.U4
				or ElementType.I8
				or ElementType.U8;

	/// <summary>
	/// Returns <see langword="true"/> when <paramref name="sig"/> refers to an enum type
	/// whose underlying primitive element type equals <paramref name="requiredElemType"/>.
	/// </summary>
	private static bool IsEnumTypeSignature(TypeDefOrRefSignature sig, ElementType requiredElemType)
	{
		if (sig.ToTypeDefOrRef() is not TypeDefinition def)
			return false;

		// Enums have a special "value__" backing field.
		foreach (FieldDefinition field in def.Fields)
		{
			if (
				field.Name == "value__"
				&& field.Signature?.FieldType is CorLibTypeSignature { ElementType: var underlying }
			)
			{
				return underlying == requiredElemType;
			}
		}

		return false;
	}
}
