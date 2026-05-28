using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Code.Cil;
using AsmResolver.DotNet.Collections;
using AsmResolver.DotNet.Signatures;
using AsmResolver.PE.DotNet.Cil;
using AssetRipper.Translation.LlvmIR.Extensions;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace AssetRipper.Translation.LlvmIR;

internal static partial class IntrinsicFunctionImplementer
{
	public static bool TryHandleIntrinsicFunction(FunctionContext context)
	{
		if (!context.IsIntrinsic)
		{
			return false;
		}

		CilInstructionCollection instructions = context.Definition.CilMethodBody!.Instructions;

		if (
			TryGetInjectedIntrinsic(
				context.Module,
				context.MangledName,
				out MethodDefinition? implementation
			)
			&& implementation.Parameters.Count == context.Definition.Parameters.Count
		)
		{
			// Set parameter names to match the implementation.
			for (int i = 0; i < context.Definition.Parameters.Count; i++)
			{
				context.Definition.Parameters[i].GetOrCreateDefinition().Name = implementation
					.Parameters[i]
					.Name;
			}

			MoveToImplementedType(context);

			foreach (Parameter parameter in context.Definition.Parameters)
			{
				instructions.Add(CilOpCodes.Ldarg, parameter);
			}

			instructions.Add(CilOpCodes.Call, context.Module.ImportRuntimeMethod(implementation));

			instructions.Add(CilOpCodes.Ret);
		}
		else if (TryImplementNumericOperation(context))
		{
			MoveToImplementedType(context);
		}
		else if (TryImplementNoOpIntrinsic(context))
		{
			MoveToImplementedType(context);
		}
		else if (TryImplementEhTypeidForIntrinsic(context))
		{
			MoveToImplementedType(context);
		}
		else if (TryImplementPassthroughIntrinsic(context))
		{
			MoveToImplementedType(context);
		}
		else if (TryImplementWithOverflowIntrinsic(context))
		{
			MoveToImplementedType(context);
		}
		else if (TryResolveDependency(context))
		{
			MoveToImplementedType(context);
		}
		else
		{
			MoveToUnimplementedType(context);

			// Warn about unresolved external C/C++ symbols — these need to be provided via
			// TranslatorOptions.Dependencies or TranslatorOptions.InlineAssemblySubstitutions.
			// LLVM intrinsic stubs (llvm.*) are expected and do not generate a warning.
			if (!context.MangledName.StartsWith("llvm.", StringComparison.Ordinal))
			{
				Console.Error.WriteLine(
					$"[WARN] Unresolved external symbol: {context.MangledName}"
				);
			}

			instructions.ThrowNotImplementedException(
				$"Unimplemented LLVM intrinsic: {context.MangledName}"
			);
		}

		context.Definition.IsAggressiveInlining = true;

		return true;
	}

	private static void MoveToImplementedType(FunctionContext context)
	{
		context.DeclaringType.Namespace = context.Module.Options.GetNamespace(
			"Intrinsics.Implemented"
		);
	}

	private static void MoveToUnimplementedType(FunctionContext context)
	{
		context.DeclaringType.Namespace = context.Module.Options.GetNamespace(
			"Intrinsics.Unimplemented"
		);
	}

	private static bool TryGetInjectedIntrinsic(
		ModuleContext context,
		string mangledName,
		[NotNullWhen(true)] out MethodDefinition? result
	)
	{
		result = context.IntrinsicsType.Methods.FirstOrDefault(m =>
		{
			if (!m.IsPublic || m.GenericParameters.Count != 0)
			{
				return false;
			}

			return m.FindCustomAttributes(
					typeof(MangledNameAttribute).Namespace,
					nameof(MangledNameAttribute)
				)
				.Select(a => a.Signature?.FixedArguments[0].Element?.ToString())
				.Contains(mangledName);
		});
		return result is not null;
	}

	private static bool TryImplementNumericOperation(FunctionContext context)
	{
		if (context.NormalParameters.Length == 0 || context.IsVoidReturn)
		{
			return false;
		}

		if (!TryGetOperationName(context.MangledName, out string? operationName))
		{
			return false;
		}

		TypeSignature returnTypeSignature = context.Definition.Signature!.ReturnType;
		TypeDefinition returnTypeDefinition =
			returnTypeSignature.Resolve()
			?? throw new NullReferenceException(nameof(returnTypeDefinition));

		MethodSpecification? implementation;
		if (
			context.Module.InlineArrayTypes.TryGetValue(
				returnTypeDefinition,
				out InlineArrayContext? arrayType
			)
		)
		{
			MethodDefinition? sourceMethod =
				context.Module.InlineArrayNumericHelperType.Methods.FirstOrDefault(m =>
					StringComparer.OrdinalIgnoreCase.Equals(m.Name, operationName) && m.IsPublic
				);
			implementation = sourceMethod is null
				? null
				: context
					.Module.ImportRuntimeMethod(sourceMethod)
					.MakeGenericInstanceMethod(returnTypeSignature, arrayType.UltimateElementType);
		}
		else
		{
			MethodDefinition? sourceMethod =
				context.Module.NumericHelperType.Methods.FirstOrDefault(m =>
					StringComparer.OrdinalIgnoreCase.Equals(m.Name, operationName) && m.IsPublic
				);
			implementation = sourceMethod is null
				? null
				: context
					.Module.ImportRuntimeMethod(sourceMethod)
					.MakeGenericInstanceMethod(returnTypeSignature);
		}
		if (implementation is null)
		{
			return false;
		}

		CilInstructionCollection instructions = context.Definition.CilMethodBody!.Instructions;

		int parameterCount = implementation.Method!.Signature!.GetTotalParameterCount();
		Debug.Assert(parameterCount is 1 or 2 or 3);
		instructions.Add(CilOpCodes.Ldarg_0);
		if (parameterCount is >= 2)
		{
			instructions.Add(CilOpCodes.Ldarg_1);
			if (parameterCount is 3)
			{
				instructions.Add(CilOpCodes.Ldarg_2);
			}
		}
		instructions.Add(CilOpCodes.Call, implementation);
		instructions.Add(CilOpCodes.Ret);

		return true;
	}

	private static bool TryGetOperationName(
		string name,
		[NotNullWhen(true)] out string? operationName
	)
	{
		if (SimpleOperationRegex.TryMatch(name, out Match? match))
		{
			operationName = match.Groups[1].Value;
			return true;
		}
		operationName = null;
		return false;
	}

	/// <summary>
	/// Handles <c>llvm.eh.typeid.for</c> (and <c>llvm.eh.typeid.for.p0</c>, etc.).
	/// These intrinsics return the DWARF type-info ID for a given C++ type-info pointer,
	/// used by landing-pad type-dispatch code (<c>icmp eq %sel, %tid</c>).
	/// This maps to <see cref="ExceptionInfo.GetTypeIdFor(void*)"/> so translated
	/// landing-pad selector checks can perform deterministic typed comparisons.
	/// </summary>
	private static bool TryImplementEhTypeidForIntrinsic(FunctionContext context)
	{
		if (!context.MangledName.StartsWith("llvm.eh.typeid.for", StringComparison.Ordinal))
		{
			return false;
		}

		// Must return an integer (i32).
		if (context.IsVoidReturn)
		{
			return false;
		}

		if (context.NormalParameters.Length != 1)
		{
			return false;
		}

		MethodDefinition typeIdHelper = context
			.Module
			.InjectedTypes[typeof(ExceptionInfo)]
			.Methods.Single(m => m.Name == nameof(ExceptionInfo.GetTypeIdFor));

		CilInstructionCollection instructions = context.Definition.CilMethodBody!.Instructions;
		instructions.Add(CilOpCodes.Ldarg_0);
		instructions.Add(CilOpCodes.Call, context.Module.ImportRuntimeMethod(typeIdHelper));
		instructions.Add(CilOpCodes.Ret);
		return true;
	}

	private static bool TryImplementNoOpIntrinsic(FunctionContext context)
	{
		// These intrinsics are semantic hints to the LLVM optimizer and have no
		// runtime effect. Emit them as void no-ops so callers are not disrupted.
		if (!context.IsVoidReturn)
		{
			return false;
		}

		if (!NoOpIntrinsicRegex.IsMatch(context.MangledName))
		{
			return false;
		}

		context.Definition.CilMethodBody!.Instructions.Add(CilOpCodes.Ret);
		return true;
	}

	/// <summary>
	/// Handles intrinsics that simply return their first argument unchanged
	/// (e.g. <c>llvm.expect.*</c> which is a branch-probability hint).
	/// </summary>
	private static bool TryImplementPassthroughIntrinsic(FunctionContext context)
	{
		if (context.IsVoidReturn || context.NormalParameters.Length == 0)
		{
			return false;
		}

		if (!PassthroughIntrinsicRegex.IsMatch(context.MangledName))
		{
			return false;
		}

		CilInstructionCollection instructions = context.Definition.CilMethodBody!.Instructions;
		instructions.Add(CilOpCodes.Ldarg_0);
		instructions.Add(CilOpCodes.Ret);
		return true;
	}

	/// <summary>
	/// Attempts to resolve the function from a previously-translated dependency assembly
	/// listed in <see cref="TranslatorOptions.Dependencies"/>.
	/// </summary>
	/// <remarks>
	/// When a match is found the method emits a simple forwarding body: loads all parameters
	/// and calls the corresponding public method in the dependency's <c>GlobalMembers</c>
	/// static class.  The mangled name guarantees signature compatibility — a match means
	/// both sides were compiled from the same C++ declaration.
	/// </remarks>
	private static bool TryResolveDependency(FunctionContext context)
	{
		IReadOnlyList<TranslatedAssemblyDependency> dependencies = context
			.Module
			.Options
			.Dependencies;
		if (dependencies.Count == 0)
		{
			return false;
		}

		foreach (TranslatedAssemblyDependency dep in dependencies)
		{
			if (!dep.TryGetFunction(context.MangledName, out MethodDefinition? depMethod))
			{
				continue;
			}

			// Sanity-check: mangled names encode the full signature so a count mismatch
			// indicates an ABI incompatibility (different compiler versions, sret mismatch,
			// etc.) — skip this dependency and let the next one try.
			if (depMethod.Parameters.Count != context.Definition.Parameters.Count)
			{
				continue;
			}

			CilInstructionCollection instructions = context.Definition.CilMethodBody!.Instructions;

			foreach (Parameter parameter in context.Definition.Parameters)
			{
				instructions.Add(CilOpCodes.Ldarg, parameter);
			}

			IMethodDefOrRef imported = dep.ImportFunctionInto(depMethod, context.Module.Definition);
			instructions.Add(CilOpCodes.Call, imported);
			instructions.Add(CilOpCodes.Ret);

			return true;
		}

		return false;
	}

	[GeneratedRegex(@"^llvm\.([a-z0-9_]+)\.([a-z0-9_]+)$")]
	private static partial Regex SimpleOperationRegex { get; }

	/// <summary>
	/// Intrinsics that are pure no-ops at the .NET level:
	/// <list type="bullet">
	///   <item><c>llvm.lifetime.start.*</c> — variable-lifetime start hint</item>
	///   <item><c>llvm.lifetime.end.*</c> — variable-lifetime end hint</item>
	///   <item><c>llvm.assume</c> — optimizer assumption hint (already handled by InjectedIntrinsic, but kept here as fallback)</item>
	/// </list>
	/// </summary>
	[GeneratedRegex(
		@"^llvm\.(lifetime\.(start|end)|dbg\.(value|declare|assign)|invariant\.start|invariant\.end|pseudoprobe)(\.[a-z0-9_]+)*$"
	)]
	private static partial Regex NoOpIntrinsicRegex { get; }

	/// <summary>
	/// Intrinsics that return their first argument unchanged.
	/// <list type="bullet">
	///   <item><c>llvm.expect.*</c> — branch-probability hint; value is returned as-is.</item>
	///   <item><c>llvm.threadlocal.address.*</c> — returns the address of the TLS variable unchanged (identity in managed code).</item>
	/// </list>
	/// </summary>
	[GeneratedRegex(@"^llvm\.(expect|threadlocal\.address)(\.[a-z0-9_]+)*$")]
	private static partial Regex PassthroughIntrinsicRegex { get; }

	/// <summary>
	/// Handles <c>llvm.uadd.with.overflow.*</c> and <c>llvm.usub.with.overflow.*</c> intrinsics.
	/// These return a struct <c>{ iN field_0; bool field_1 }</c> where <c>field_0</c> is the
	/// wrapping arithmetic result and <c>field_1</c> is the unsigned overflow flag.
	/// Since the return struct is a per-module generated type, this must be implemented by
	/// emitting CIL directly rather than via a runtime method.
	/// </summary>
	private static bool TryImplementWithOverflowIntrinsic(FunctionContext context)
	{
		Match match = WithOverflowIntrinsicRegex.Match(context.MangledName);
		if (!match.Success)
		{
			return false;
		}

		bool isAdd = match.Groups[1].Value == "uadd";
		int bits = int.Parse(match.Groups[2].Value.TrimStart('i')); // strip 'i' prefix: i16→16, i32→32, i64→64

		// The return type is a generated struct with field_0 (value) and field_1 (overflow bool).
		TypeSignature? returnSig = context.Definition.Signature?.ReturnType;
		if (returnSig?.Resolve() is not TypeDefinition returnStruct)
		{
			return false;
		}

		FieldDefinition? field0 = returnStruct.Fields.FirstOrDefault(f => f.Name == "field_0");
		FieldDefinition? field1 = returnStruct.Fields.FirstOrDefault(f => f.Name == "field_1");
		if (field0 is null || field1 is null)
		{
			return false;
		}

		CilMethodBody body = context.Definition.CilMethodBody!;
		CilLocalVariable resultLocal = new(returnSig);
		body.LocalVariables.Add(resultLocal);
		CilInstructionCollection ins = body.Instructions;

		// Zero-initialize the result struct.
		ins.Add(CilOpCodes.Ldloca, resultLocal);
		ins.Add(CilOpCodes.Initobj, returnStruct);

		// ── field_0: wrapping arithmetic result ──────────────────────────────
		ins.Add(CilOpCodes.Ldloca, resultLocal);
		ins.Add(CilOpCodes.Ldarg_0);
		ins.Add(CilOpCodes.Ldarg_1);
		// CilOpCodes.Add / Sub are unchecked at the CIL level regardless of
		// <CheckForOverflowUnderflow> (that only affects C# compiler output).
		ins.Add(isAdd ? CilOpCodes.Add : CilOpCodes.Sub);
		if (bits == 16)
			ins.Add(CilOpCodes.Conv_I2); // truncate int32 result to i16
		// i32: already int32; i64: already int64 — no extra truncation needed
		ins.Add(CilOpCodes.Stfld, field0);

		// ── field_1: unsigned overflow flag ───────────────────────────────────
		// For uadd: overflow = (unsigned)(a + b) < (unsigned)a
		// For usub: overflow = (unsigned)a < (unsigned)b
		ins.Add(CilOpCodes.Ldloca, resultLocal);

		if (isAdd)
		{
			// Recompute a + b so we can compare with a.
			ins.Add(CilOpCodes.Ldarg_0);
			ins.Add(CilOpCodes.Ldarg_1);
			ins.Add(CilOpCodes.Add);
		}
		else
		{
			// Just load a for the left side of the comparison.
			ins.Add(CilOpCodes.Ldarg_0);
		}

		// Zero-extend to the unsigned interpretation appropriate for this width.
		CilOpCode convResult = bits switch
		{
			16 => CilOpCodes.Conv_U2,
			32 => CilOpCodes.Conv_U4,
			_ => CilOpCodes.Conv_U8, // 64
		};
		ins.Add(convResult);

		// Right-hand side of comparison: always (unsigned)a for uadd, (unsigned)b for usub.
		ins.Add(isAdd ? CilOpCodes.Ldarg_0 : CilOpCodes.Ldarg_1);
		ins.Add(convResult);

		ins.Add(CilOpCodes.Clt_Un); // unsigned less-than → 1 (true) if overflow
		ins.Add(CilOpCodes.Stfld, field1);

		// Return the struct by value.
		ins.Add(CilOpCodes.Ldloc, resultLocal);
		ins.Add(CilOpCodes.Ret);
		return true;
	}

	[GeneratedRegex(@"^llvm\.(uadd|usub)\.with\.overflow\.(i16|i32|i64)$")]
	private static partial Regex WithOverflowIntrinsicRegex { get; }
}
