using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmElsEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator<<(unsigned long) const")]
[CleanName("BigInt_256ul_false_unsigned_long_operator_unsigned_long_const")]
internal static partial class BigInt_256ul_false_unsigned_long_operator_unsigned_long_const_kxxaxj
{
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, BigInt_x9dsed* @this, long s)
	{
		cpp_array_jgy3xh cpp_array_jgy3xh2 = default(cpp_array_jgy3xh);
		cpp_array_jgy3xh cpp_array_jgy3xh3 = default(cpp_array_jgy3xh);
		llvm_lifetime_start_p0.Invoke(32L, &cpp_array_jgy3xh2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_jgy3xh3, &@this->val, 32L, isVolatile: false);
		cpp_array_unsigned_long_4ul_multiword_shift_multiword_Direction_0_false_unsigned_long_4ul_cpp_array_unsigned_long_4ul_unsigned_long.Invoke(&cpp_array_jgy3xh2, &cpp_array_jgy3xh3, s);
		BigInt_256ul_false_unsigned_long_BigInt_cpp_array_unsigned_long_4ul_const.Invoke(agg_result, &cpp_array_jgy3xh2);
		llvm_lifetime_end_p0.Invoke(32L, &cpp_array_jgy3xh2);
	}
}
