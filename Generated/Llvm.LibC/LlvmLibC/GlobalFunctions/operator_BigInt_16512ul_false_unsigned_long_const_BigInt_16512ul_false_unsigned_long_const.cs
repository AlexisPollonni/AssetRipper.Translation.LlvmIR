using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_gtERKNS_6BigIntILm16512ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator>(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&)")]
internal static partial class operator_BigInt_16512ul_false_unsigned_long_const_BigInt_16512ul_false_unsigned_long_const
{
	public unsafe static bool Invoke(void* lhs, void* rhs)
	{
		return cmp_BigInt_16512ul_false_unsigned_long_const_BigInt_16512ul_false_unsigned_long_const.Invoke(lhs, rhs) > 0;
	}
}
