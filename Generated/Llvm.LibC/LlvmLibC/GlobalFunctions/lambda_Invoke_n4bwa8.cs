using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_n4bwa8
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_3cmpERKNS_6BigIntILm128ELb0EmEES3_ENKUlmmE_clEmm")]
	[DemangledName("__llvm_libc_20_1_2_::cmp(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)::'lambda'(unsigned long, unsigned long)::operator()(unsigned long, unsigned long) const")]
	[CleanName("lambda_Invoke")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned long")] long a, [NativeType("unsigned long")] long b)
	{
		return (a != b) ? InstructionHelper.Select(unchecked((ulong)a > (ulong)b), 1, -1) : 0;
	}
}
