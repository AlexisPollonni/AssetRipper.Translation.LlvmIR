using AsmResolver.DotNet.Code.Cil;
using AsmResolver.PE.DotNet.Cil;
using AssetRipper.Translation.LlvmIR.Extensions;

namespace AssetRipper.Translation.LlvmIR.Instructions;

internal sealed record class UnreachableInstruction : Instruction
{
	public static UnreachableInstruction Instance { get; } = new();
	public override int PopCount => 0;
	public override int PushCount => 0;

	public override void AddInstructions(CilInstructionCollection instructions)
	{
		instructions.ThrowNotImplementedException("Reached LLVM unreachable instruction.");
	}
}
