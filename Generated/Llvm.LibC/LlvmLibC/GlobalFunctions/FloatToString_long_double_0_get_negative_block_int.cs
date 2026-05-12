using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE18get_negative_blockEi")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_negative_block(int)")]
internal static partial class FloatToString_long_double_0_get_negative_block_int
{
	public unsafe static int Invoke(FloatToString_8m29tk* @this, int negative_block_index)
	{
		int num = 0;
		BigInt_k36xhe bigInt_k36xhe = default(BigInt_k36xhe);
		int result;
		if (@this->exponent >= 0)
		{
			result = 0;
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = -1 - negative_block_index;
			while (num < @this->int_block_index)
			{
				FloatToString_long_double_0_zero_leading_digits_BigInt_16512ul_false_unsigned_long.Invoke(&@this->float_as_fixed);
				BigInt_16512ul_false_unsigned_long_mul_unsigned_long.Invoke(&@this->float_as_fixed, 1000000000L);
				@this->int_block_index += -1;
			}
			llvm_lifetime_start_p0.Invoke(2064L, &bigInt_k36xhe);
			BigInt_16512ul_false_unsigned_long_operator_unsigned_long_const_zwn8yf.Invoke(&bigInt_k36xhe, &@this->float_as_fixed, 16384L);
			result = BigInt_16512ul_false_unsigned_long_operator_unsigned_int_unsigned_int_const.Invoke(&bigInt_k36xhe);
			llvm_lifetime_end_p0.Invoke(2064L, &bigInt_k36xhe);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return result;
	}
}
