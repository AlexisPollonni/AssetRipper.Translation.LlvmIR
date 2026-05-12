using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_ltERKNS_6BigIntILm128ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator<(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const_5jnex6
{
	public unsafe static bool Invoke(anon_izyfb7* lhs, anon_izyfb7* rhs)
	{
		return cmp_BigInt_128ul_false_unsigned_long_const_BigInt_128ul_false_unsigned_long_const.Invoke(lhs, rhs) < 0;
	}
}
