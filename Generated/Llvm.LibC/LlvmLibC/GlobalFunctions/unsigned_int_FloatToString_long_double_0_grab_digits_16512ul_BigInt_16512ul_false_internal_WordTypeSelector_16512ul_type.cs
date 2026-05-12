using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE11grab_digitsILm16512EEEjRNS_6BigIntIXT_ELb0ENS_8internal16WordTypeSelectorIXT_EE4typeEEE")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::FloatToString<long double, 0>::grab_digits<16512ul>(__llvm_libc_20_1_2_::BigInt<16512ul, false, __llvm_libc_20_1_2_::internal::WordTypeSelector<16512ul>::type>&)")]
internal static partial class unsigned_int_FloatToString_long_double_0_grab_digits_16512ul_BigInt_16512ul_false_internal_WordTypeSelector_16512ul_type
{
	public unsafe static int Invoke(BigInt_k36xhe* int_num)
	{
		cpp_optional_tchbah cpp_optional_tchbah2 = default(cpp_optional_tchbah);
		llvm_lifetime_start_p0.Invoke(2072L, &cpp_optional_tchbah2);
		llvm_memset_p0_i64.Invoke(&cpp_optional_tchbah2, -86, 2072L, isVolatile: false);
		BigInt_16512ul_false_unsigned_long_div_uint_half_times_pow_2_unsigned_int_unsigned_long.Invoke(&cpp_optional_tchbah2, int_num, 1953125, 9L);
		int result = BigInt_16512ul_false_unsigned_long_operator_unsigned_int_unsigned_int_const.Invoke(cpp_optional_BigInt_16512ul_false_unsigned_long_value.Invoke(&cpp_optional_tchbah2));
		llvm_lifetime_end_p0.Invoke(2072L, &cpp_optional_tchbah2);
		return result;
	}
}
