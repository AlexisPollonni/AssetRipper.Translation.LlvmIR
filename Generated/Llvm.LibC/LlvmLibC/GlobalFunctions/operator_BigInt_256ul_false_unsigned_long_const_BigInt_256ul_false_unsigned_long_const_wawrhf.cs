using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_geERKNS_6BigIntILm256ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator>=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_wawrhf
{
	public unsafe static bool Invoke(void* lhs, void* rhs)
	{
		return cmp_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const.Invoke(lhs, rhs) >= 0;
	}
}
