using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_3cmpERKNS_6BigIntILm64ELb0EmEES3_ENKUlmmE_clEmm")]
[DemangledName("__llvm_libc_20_1_2_::cmp(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)::'lambda'(unsigned long, unsigned long)::operator()(unsigned long, unsigned long) const")]
internal static partial class cmp_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_lambda_unsigned_long_unsigned_long_operator_unsigned_long_unsigned_long_const
{
	public unsafe static int Invoke(void* @this, long a, long b)
	{
		return (a != b) ? InstructionHelper.Select(unchecked((ulong)a > (ulong)b), 1, -1) : 0;
	}
}
