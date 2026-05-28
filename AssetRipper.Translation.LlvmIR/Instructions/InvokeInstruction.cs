using AsmResolver.DotNet;
using AsmResolver.DotNet.Code.Cil;
using AsmResolver.PE.DotNet.Cil;
using AssetRipper.Translation.LlvmIR.Variables;

namespace AssetRipper.Translation.LlvmIR.Instructions;

/// <summary>
/// Wraps a direct method call inside a CLR structured-exception-handling try/catch region,
/// modelling the Itanium C++ ABI <c>invoke</c> instruction.
///
/// Arguments must already be on the evaluation stack before this instruction is executed
/// (they are pushed by the preceding <c>LoadValue</c> calls in the basic block).
/// On success the callee's return value (if any) is stored into <see cref="ResultVariable"/>
/// and control falls through to <see cref="NormalBlock"/> via a <c>leave</c>.
/// On a caught <see cref="Runtime.ExceptionInfo"/> the exception is stored in
/// <see cref="ExceptionInfoCurrentField"/> and control transfers to <see cref="CatchBlock"/>
/// via a <c>leave</c>.
/// </summary>
internal sealed record class InvokeInstruction(
	IMethodDescriptor Method,
	IReadOnlyList<IVariable> Arguments,
	IVariable? ResultVariable,
	BasicBlock NormalBlock,
	BasicBlock CatchBlock,
	FieldDefinition ExceptionInfoCurrentField,
	TypeDefinition ExceptionInfoType
) : Instruction
{
	private bool IsStaticCall => !Method.Signature!.HasThis;

	/// <summary>
	/// Argument materialization is done before entering this instruction, but the actual
	/// IL loads happen inside the try region to keep EH region boundaries stack-empty.
	/// </summary>
	public override int PopCount => 0;

	/// <summary>
	/// The result (if any) is stored into <see cref="ResultVariable"/> inside the
	/// try block and is therefore not left on the stack.
	/// </summary>
	public override int PushCount => 0;

	/// <summary>
	/// The try/catch region and the implicit leave instructions mean the stack height
	/// at the end of this instruction is not simply derivable from pop/push counts.
	/// </summary>
	public override bool StackHeightDependent => true;

	public override void AddInstructions(CilInstructionCollection instructions)
	{
		ModuleDefinition module = instructions.Owner.Owner!.DeclaringModule!;
		IMethodDescriptor importedMethod = module.DefaultImporter.ImportMethod(Method);
		IFieldDescriptor importedField =
			(IFieldDescriptor)module.DefaultImporter.ImportField(ExceptionInfoCurrentField);
		ITypeDefOrRef importedExType =
			(ITypeDefOrRef)module.DefaultImporter.ImportType(ExceptionInfoType);

		// ── try { ──────────────────────────────────────────────────────────────
		CilInstruction tryStartInstruction = instructions.Add(CilOpCodes.Nop);
		ICilLabel tryStart = tryStartInstruction.CreateLabel();

		for (int i = 0; i < Arguments.Count; i++)
		{
			Arguments[i].AddLoad(instructions);
		}

		instructions.Add(
			IsStaticCall ? CilOpCodes.Call : CilOpCodes.Callvirt,
			importedMethod
		);

		// Store the return value inside the try block (before the leave).
		if (ResultVariable is not null)
		{
			ResultVariable.AddStore(instructions);
		}

		// Leave to the normal successor block.
		instructions.Add(CilOpCodes.Leave, NormalBlock.Label);

		// ── catch (ExceptionInfo) { ────────────────────────────────────────────
		// The CLR pushes the caught ExceptionInfo onto the stack here.
		CilInstruction catchStore = instructions.Add(CilOpCodes.Stsfld, importedField);
		// Keep try-end and handler-start contiguous at the same instruction.
		// Leaving a gap (even a nop) between ranges can JIT-fail with
		// InvalidProgramException for generated invoke methods.
		// EH table end labels are exclusive: the try region ends at the first
		// instruction of the catch handler.
		ICilLabel tryEnd = catchStore.CreateLabel();
		ICilLabel catchStart = tryEnd;

		// Leave to the landing-pad (unwind) successor block.
		instructions.Add(CilOpCodes.Leave, CatchBlock.Label);
		// Same exclusive-end rule for the handler range.
		CilInstruction catchEndMarker = instructions.Add(CilOpCodes.Nop);
		ICilLabel catchEnd = catchEndMarker.CreateLabel();

		// ── Register the exception handler ─────────────────────────────────────
		instructions.Owner.ExceptionHandlers.Add(new CilExceptionHandler
		{
			HandlerType = CilExceptionHandlerType.Exception,
			TryStart = tryStart,
			TryEnd = tryEnd,
			HandlerStart = catchStart,
			HandlerEnd = catchEnd,
			ExceptionType = importedExType,
		});
	}
}
