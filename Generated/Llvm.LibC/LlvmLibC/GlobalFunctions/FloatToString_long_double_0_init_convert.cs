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
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_FloatToString_8m29tk* This)
	{
		Llvm_libc_20_1_2_BigInt_q8g275 llvm_libc_20_1_2_BigInt_q8g = default(Llvm_libc_20_1_2_BigInt_q8g275);
		Int128 @int = default(Int128);
		Llvm_libc_20_1_2_BigInt_q8g275 llvm_libc_20_1_2_BigInt_q8g2 = default(Llvm_libc_20_1_2_BigInt_q8g275);
		Llvm_libc_20_1_2_BigInt_q8g275 llvm_libc_20_1_2_BigInt_q8g3 = default(Llvm_libc_20_1_2_BigInt_q8g275);
		Int128 int2 = default(Int128);
		int num = 0;
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_q8g275 llvm_libc_20_1_2_BigInt_q8g4 = default(Llvm_libc_20_1_2_BigInt_q8g275);
		long num2 = 0L;
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh2 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		if (NumericHelper.IntCmpEq(This->Mantissa, 0L) && This->Exponent == 0)
		{
			return;
		}
		unchecked
		{
			if (This->Exponent > 0)
			{
				Llvm_lifetime_start_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_q8g, -86, 2064L, isVolatile: false);
				@int = This->Mantissa;
				BigInt_16512ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&llvm_libc_20_1_2_BigInt_q8g, *(long*)(&@int), ((long*)(&@int))[1]);
				BigInt_16512ul_false_unsigned_long_Operator.Invoke(&llvm_libc_20_1_2_BigInt_q8g, This->Exponent);
				This->Int_block_index = 0;
				while (true)
				{
					Llvm_lifetime_start_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g2);
					BigInt_16512ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_q8g2, 0);
					bool num3 = Llvm_libc_20_1_2_GreaterThan_amy9iu.Invoke(&llvm_libc_20_1_2_BigInt_q8g, &llvm_libc_20_1_2_BigInt_q8g2);
					Llvm_lifetime_end_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g2);
					if (!num3)
					{
						break;
					}
					int num4 = FloatToString_long_double_0_grab_digits_16512ul.Invoke(&llvm_libc_20_1_2_BigInt_q8g);
					((int*)(&This->Block_buffer))[This->Int_block_index] = num4;
					checked
					{
						This->Int_block_index++;
					}
				}
				This->Block_buffer_valid = This->Int_block_index;
				Llvm_lifetime_end_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g);
				return;
			}
			Llvm_lifetime_start_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g3);
			int2 = This->Mantissa;
			BigInt_16512ul_false_unsigned_long_BigInt_unsigned_int128_void.Invoke(&llvm_libc_20_1_2_BigInt_q8g3, *(long*)(&int2), ((long*)(&int2))[1]);
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Float_as_fixed, &llvm_libc_20_1_2_BigInt_q8g3, 2064L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g3);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = (int)(16384L + This->Exponent);
			BigInt_16512ul_false_unsigned_long_Operator.Invoke(&This->Float_as_fixed, num);
			if (Cpp_countl_zero_BigInt_16512ul_false_unsigned_long.Invoke(&This->Float_as_fixed) < 128)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh);
				*(long*)ptr = -6148914691236517206L;
				((long*)ptr)[1] = -6148914691236517206L;
				Llvm_lifetime_start_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g4);
				BigInt_16512ul_false_unsigned_long_RightShift.Invoke(&llvm_libc_20_1_2_BigInt_q8g4, &This->Float_as_fixed, 16384L);
				BigInt_128ul_false_unsigned_long_BigInt_16512ul_false_unsigned_long.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), &llvm_libc_20_1_2_BigInt_q8g4);
				Llvm_lifetime_end_p0.Invoke(2064L, &llvm_libc_20_1_2_BigInt_q8g4);
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				while (true)
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
					BigInt_128ul_false_unsigned_long_BigInt_int_void.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2), 0);
					bool num5 = Llvm_libc_20_1_2_GreaterThan_tk7vzq.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2));
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
					if (!num5)
					{
						break;
					}
					int num6 = FloatToString_long_double_0_grab_digits_128ul.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh));
					((int*)(&This->Block_buffer))[num2] = num6;
					num2++;
				}
				This->Block_buffer_valid = num2;
				FloatToString_long_double_0_zero_leading_digits.Invoke(&This->Float_as_fixed);
				This->Int_block_index = 0;
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
