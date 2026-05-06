using LLVMSharp.Interop;

namespace AssetRipper.Translation.LlvmIR.Extensions;

internal static class LLVMMetadataRefExtensions
{
	extension(LLVMMetadataRef metadata)
	{
		public bool IsEnum =>
			metadata.Kind is LLVMMetadataKind.LLVMDICompositeTypeMetadataKind
			&& metadata.TagString is "DW_TAG_enumeration_type";

		public bool IsStruct =>
			metadata.Kind is LLVMMetadataKind.LLVMDICompositeTypeMetadataKind
			&& metadata.TagString is "DW_TAG_structure_type";

		public bool IsClass =>
			metadata.Kind is LLVMMetadataKind.LLVMDICompositeTypeMetadataKind
			&& metadata.TagString is "DW_TAG_class_type";

		public bool IsUnion =>
			metadata.Kind is LLVMMetadataKind.LLVMDICompositeTypeMetadataKind
			&& metadata.TagString is "DW_TAG_union_type";

		public bool IsArray =>
			metadata.Kind is LLVMMetadataKind.LLVMDICompositeTypeMetadataKind
			&& metadata.TagString is "DW_TAG_array_type";

		public bool IsPointer =>
			metadata.Kind is LLVMMetadataKind.LLVMDIDerivedTypeMetadataKind
			&& metadata.TagString is "DW_TAG_pointer_type";

		public long ArrayLength
		{
			get
			{
				if (!metadata.IsArray)
				{
					return default;
				}

				LLVMMetadataRef[] elements = metadata.Elements;
				if (elements.Length != 1)
				{
					return default;
				}

				return elements[0].Count.ConstIntSExt;
			}
		}

		public LLVMMetadataRef[] Elements =>
			metadata.IsADICompositeType != default
				? llvmsharp.DICompositeType_getElements(metadata)
				: [];

		public string IdentifierDemangled
		{
			get
			{
				string identifier = metadata.Identifier;
				if (string.IsNullOrEmpty(identifier))
				{
					return "";
				}
				string demangled = llvmsharp.Demangle(identifier);
				// Itanium _ZTS... symbols demangle to "typeinfo name for <qualified-name>"
				demangled = demangled.RemovePrefix("typeinfo name for ");
				// MSVC typeinfo symbols
				demangled = demangled.RemoveSuffix(" `RTTI Type Descriptor Name'");
				return demangled;
			}
		}

		public string IdentifierClean
		{
			get
			{
				string demangled = metadata.IdentifierDemangled;
				if (string.IsNullOrEmpty(demangled))
				{
					return "";
				}

				if (DemangledNamesParser.ParseType(demangled, out string? cleanType))
				{
					return cleanType;
				}
				else
				{
					return "";
				}
			}
		}

		public IEnumerable<LLVMMetadataRef> Members =>
			metadata.Elements.Where(e => e.TagString is "DW_TAG_member");

		/// <summary>
		/// All struct layout entries that correspond to LLVM struct fields:
		/// both <c>DW_TAG_member</c> (regular fields) and
		/// <c>DW_TAG_inheritance</c> (base-class sub-objects stored as the first field(s)).
		/// Subprograms, template parameters, etc. are excluded.
		/// </summary>
		public IEnumerable<LLVMMetadataRef> AllDataMembers =>
			metadata.Elements.Where(e => e.TagString is "DW_TAG_member" or "DW_TAG_inheritance");

		/// <summary>
		/// Returns the best field name for a layout member element.
		/// For <c>DW_TAG_member</c> this is the member's own name.
		/// For <c>DW_TAG_inheritance</c> this is derived from the base-class type name
		/// (short unqualified name, template arguments stripped).
		/// </summary>
		public string LayoutMemberName
		{
			get
			{
				if (metadata.TagString is "DW_TAG_inheritance")
				{
					string baseClass = metadata.BaseType.Name;
					// Strip template arguments: "FPRepImpl<(FPType)1, ...>" → "FPRepImpl"
					int lt = baseClass.IndexOf('<');
					if (lt > 0)
					{
						baseClass = baseClass[..lt];
					}
					// Strip qualification: "some::ns::Name" → "Name"
					int lastSep = baseClass.LastIndexOf("::", StringComparison.Ordinal);
					if (lastSep >= 0)
					{
						baseClass = baseClass[(lastSep + 2)..];
					}
					return string.IsNullOrEmpty(baseClass) ? "base" : baseClass;
				}
				return metadata.Name;
			}
		}

		public LLVMMetadataRef PassThroughToBaseTypeIfNecessary()
		{
			if (metadata.IsADIDerivedType == default)
			{
				return metadata;
			}

			if (
				metadata.TagString
				is "DW_TAG_typedef"
					or "DW_TAG_const_type"
					or "DW_TAG_volatile_type"
					or "DW_TAG_restrict_type"
			)
			{
				return metadata.BaseType.PassThroughToBaseTypeIfNecessary();
			}

			return metadata;
		}
	}
}
