using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_init_convert
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EE12init_convertEv")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::init_convert()")]
	public unsafe static void Invoke(FloatToString_8m29tk* @this)
	{
		BigInt_q8g275 bigInt_q8g = default(BigInt_q8g275);
		Int128 @int = default(Int128);
		BigInt_q8g275 bigInt_q8g2 = default(BigInt_q8g275);
		BigInt_q8g275 bigInt_q8g3 = default(BigInt_q8g275);
		Int128 int2 = default(Int128);
		int num = 0;
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		BigInt_q8g275 bigInt_q8g4 = default(BigInt_q8g275);
		long num2 = 0L;
		BigInt_qdkjbh bigInt_qdkjbh2 = default(BigInt_qdkjbh);
		if (NumericHelper.IntCmpEq(@this->mantissa, 0L) && @this->exponent == 0)
		{
			return;
		}
		unchecked
		{
			if (@this->exponent > 0)
			{
				llvm_lifetime_start_p0.Invoke(2064L, &bigInt_q8g);
				llvm_memset_p0_i64.Invoke(&bigInt_q8g, -86, 2064L, isVolatile: false);
				@int = @this->mantissa;
				BigInt_16512ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&bigInt_q8g, *(long*)(&@int), ((long*)(&@int))[1]);
				BigInt_16512ul_false_unsigned_long_Operator.Invoke(&bigInt_q8g, @this->exponent);
				@this->int_block_index = 0;
				while (true)
				{
					llvm_lifetime_start_p0.Invoke(2064L, &bigInt_q8g2);
					BigInt_16512ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_q8g2, 0);
					bool num3 = GreaterThan_amy9iu.Invoke(&bigInt_q8g, &bigInt_q8g2);
					llvm_lifetime_end_p0.Invoke(2064L, &bigInt_q8g2);
					if (!num3)
					{
						break;
					}
					int num4 = FloatToString_long_double_0_grab_digits_16512ul.Invoke(&bigInt_q8g);
					((int*)(&@this->block_buffer))[@this->int_block_index] = num4;
					checked
					{
						@this->int_block_index++;
					}
				}
				@this->block_buffer_valid = @this->int_block_index;
				llvm_lifetime_end_p0.Invoke(2064L, &bigInt_q8g);
				return;
			}
			llvm_lifetime_start_p0.Invoke(2064L, &bigInt_q8g3);
			int2 = @this->mantissa;
			BigInt_16512ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&bigInt_q8g3, *(long*)(&int2), ((long*)(&int2))[1]);
			llvm_memcpy_p0_p0_i64.Invoke(&@this->float_as_fixed, &bigInt_q8g3, 2064L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(2064L, &bigInt_q8g3);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = (int)(16384L + @this->exponent);
			BigInt_16512ul_false_unsigned_long_Operator.Invoke(&@this->float_as_fixed, num);
			if (cpp_countl_zero_BigInt_16512ul_false_unsigned_long.Invoke(&@this->float_as_fixed) < 128)
			{
				llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
				sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				llvm_lifetime_start_p0.Invoke(2064L, &bigInt_q8g4);
				BigInt_16512ul_false_unsigned_long_RightShift.Invoke(&bigInt_q8g4, &@this->float_as_fixed, 16384L);
				BigInt_128ul_false_unsigned_long_BigInt_16512ul_false_unsigned_long.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), &bigInt_q8g4);
				llvm_lifetime_end_p0.Invoke(2064L, &bigInt_q8g4);
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				while (true)
				{
					llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh2);
					BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((anon_izyfb7*)(&bigInt_qdkjbh2), 0);
					bool num5 = GreaterThan_tk7vzq.Invoke((anon_izyfb7*)(&bigInt_qdkjbh), (anon_izyfb7*)(&bigInt_qdkjbh2));
					llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh2);
					if (!num5)
					{
						break;
					}
					int num6 = FloatToString_long_double_0_grab_digits_128ul.Invoke((anon_izyfb7*)(&bigInt_qdkjbh));
					((int*)(&@this->block_buffer))[num2] = num6;
					num2++;
				}
				@this->block_buffer_valid = num2;
				FloatToString_long_double_0_zero_leading_digits.Invoke(&@this->float_as_fixed);
				@this->int_block_index = 0;
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
