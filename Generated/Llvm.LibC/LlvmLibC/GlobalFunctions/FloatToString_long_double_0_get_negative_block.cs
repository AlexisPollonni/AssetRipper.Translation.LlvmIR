using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_get_negative_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE18get_negative_blockEi")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::get_negative_block(int)")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_FloatToString_8m29tk* This, [MangledName("negative_block_index")][NativeType("int")] int Negative_block_index)
	{
		int num = 0;
		Llvm_libc_20_1_2_BigInt_q8g275 llvm_libc_20_1_2_BigInt_q8g = default(Llvm_libc_20_1_2_BigInt_q8g275);
		int result;
		if (This->Exponent >= 0)
		{
			result = 0;
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = -1 - Negative_block_index;
			while (num < This->Int_block_index)
			{
				FloatToString_long_double_0_zero_leading_digits.Invoke(&This->Float_as_fixed);
				BigInt_16512ul_false_unsigned_long_mul.Invoke(&This->Float_as_fixed, 1000000000L);
				This->Int_block_index += -1;
			}
			Llvm_lifetime_start_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g);
			BigInt_16512ul_false_unsigned_long_RightShift.Invoke(&llvm_libc_20_1_2_BigInt_q8g, &This->Float_as_fixed, 16384L);
			result = BigInt_16512ul_false_unsigned_long_Unsigned_int_unsigned_int.Invoke(&llvm_libc_20_1_2_BigInt_q8g);
			Llvm_lifetime_end_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return result;
	}
}
