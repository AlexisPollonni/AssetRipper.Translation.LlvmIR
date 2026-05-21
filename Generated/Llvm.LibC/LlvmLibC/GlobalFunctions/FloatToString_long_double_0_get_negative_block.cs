using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_get_negative_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE18get_negative_blockEi")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_negative_block(int)")]
	public unsafe static int Invoke(FloatToString_8m29tk* @this, [NativeType("int")] int negative_block_index)
	{
		int num = 0;
		BigInt_q8g275 bigInt_q8g = default(BigInt_q8g275);
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
				FloatToString_long_double_0_zero_leading_digits.Invoke(&@this->float_as_fixed);
				BigInt_16512ul_false_unsigned_long_mul.Invoke(&@this->float_as_fixed, 1000000000L);
				@this->int_block_index += -1;
			}
			llvm_lifetime_start_p0.Invoke(2064L, &bigInt_q8g);
			BigInt_16512ul_false_unsigned_long_RightShift.Invoke(&bigInt_q8g, &@this->float_as_fixed, 16384L);
			result = BigInt_16512ul_false_unsigned_long_unsigned_int_unsigned_int.Invoke(&bigInt_q8g);
			llvm_lifetime_end_p0.Invoke(2064L, &bigInt_q8g);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return result;
	}
}
