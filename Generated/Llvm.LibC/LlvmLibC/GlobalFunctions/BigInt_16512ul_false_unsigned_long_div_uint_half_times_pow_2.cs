using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16512ul_false_unsigned_long_div_uint_half_times_pow_2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmE25div_uint_half_times_pow_2Ejm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::div_uint_half_times_pow_2(unsigned int, unsigned long)")]
	public unsafe static void Invoke([MangledName("agg.result")] Cpp_optional_he65ea* Agg_result, [MangledName("this")] BigInt_q8g275* This, [MangledName("x")] int X, [MangledName("e")] long E)
	{
		BigInt_q8g275 bigInt_q8g = default(BigInt_q8g275);
		BigInt_q8g275 bigInt_q8g2 = default(BigInt_q8g275);
		BigInt_q8g275 bigInt_q8g3 = default(BigInt_q8g275);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		long num9 = 0L;
		long num10 = 0L;
		long num11 = 0L;
		long num12 = 0L;
		long num13 = 0L;
		Llvm_lifetime_start_p0.Invoke(2064L, &bigInt_q8g);
		Llvm_memset_p0_i64.Invoke(&bigInt_q8g, -86, 2064L, isVolatile: false);
		BigInt_16512ul_false_unsigned_long_Constructor.Invoke(&bigInt_q8g);
		unchecked
		{
			if (X == 0)
			{
				Optional_BigInt_16512ul_false_unsigned_long_Constructor.Invoke(Agg_result);
			}
			else if ((ulong)E >= 16512uL)
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&bigInt_q8g, This, 2064L, isVolatile: false);
				Llvm_lifetime_start_p0.Invoke(2064L, &bigInt_q8g2);
				Llvm_memset_p0_i64.Invoke(&bigInt_q8g2, 0, 2064L, isVolatile: false);
				BigInt_16512ul_false_unsigned_long_Constructor.Invoke(&bigInt_q8g2);
				Llvm_memcpy_p0_p0_i64.Invoke(This, &bigInt_q8g2, 2064L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(2064L, &bigInt_q8g2);
				Optional_BigInt_16512ul_false_unsigned_long_Constructor.Invoke(Agg_result, &bigInt_q8g);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(2064L, &bigInt_q8g3);
				Llvm_memset_p0_i64.Invoke(&bigInt_q8g3, -86, 2064L, isVolatile: false);
				BigInt_16512ul_false_unsigned_long_Constructor.Invoke(&bigInt_q8g3);
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = (uint)X;
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 6L;
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = 32L;
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = 4294967295L;
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = (E >>> 6) + (((E & 0x3FL) != 0L) ? 1L : 0L) << 6;
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = (long)((ulong)num5 / 64uL);
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = 0L;
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = 258L;
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				for (num9 = 258L - num6; (ulong)num9 > 0uL; num9 += -1L)
				{
					num7 <<= 32;
					Cpp_array_anzbtp* val = &This->Val;
					long num14 = num8 + -1L;
					num8 = num14;
					long num15 = *(long*)Array_unsigned_long_258ul_Index_cpunpn.Invoke(val, num14) >>> 32;
					num7 += num15;
					Llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = (long)((ulong)num7 / (ulong)num);
					num7 = (long)((ulong)num7 % (ulong)num);
					num7 <<= 32;
					long num16 = *(long*)Array_unsigned_long_258ul_Index_cpunpn.Invoke(&This->Val, num8) & 0xFFFFFFFFL;
					num7 += num16;
					long num17 = (num10 << 32) + (long)((ulong)num7 / (ulong)num);
					*(long*)Array_unsigned_long_258ul_Index_cpunpn.Invoke(&bigInt_q8g3.Val, num9 - 1L) = num17;
					num7 = (long)((ulong)num7 % (ulong)num);
					Llvm_lifetime_end_p0.Invoke(8L, &num10);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = num5 - E;
				if ((ulong)num11 > 0uL)
				{
					BigInt_16512ul_false_unsigned_long_Operator.Invoke(&bigInt_q8g3, num11);
					Llvm_lifetime_start_p0.Invoke(8L, &num12);
					num12 = 0L;
					Llvm_lifetime_start_p0.Invoke(8L, &num13);
					Cpp_array_anzbtp* val2 = &This->Val;
					long num18 = num8 + -1L;
					num8 = num18;
					num13 = *(long*)Array_unsigned_long_258ul_Index_cpunpn.Invoke(val2, num18);
					if ((ulong)num11 >= 32uL)
					{
						num7 <<= 32;
						num7 += num13 >>> 32;
						num13 &= 0xFFFFFFFFL;
						num12 = (long)((ulong)num7 / (ulong)num);
						num7 = (long)((ulong)num7 % (ulong)num);
						num11 -= 32L;
					}
					else
					{
						num13 >>>= 32;
					}
					if ((ulong)num11 > 0uL)
					{
						num7 <<= 32;
						num7 += num13;
						num12 <<= (int)num11;
						num <<= (int)(32L - num11);
						num12 += (long)((ulong)num7 / (ulong)num);
						num7 = (long)((ulong)num7 % (ulong)num);
					}
					long num19 = num12;
					*(long*)Array_unsigned_long_258ul_Index_cpunpn.Invoke(&bigInt_q8g3.Val, 0L) += num19;
					if ((ulong)(num5 - E) <= 32uL)
					{
						if ((ulong)num8 < 257uL)
						{
							long num20 = num7 >>> 32;
							*(long*)BigInt_16512ul_false_unsigned_long_Index_jsva56.Invoke(&bigInt_q8g, num8 + 1L) = num20;
						}
						long num21 = (num7 << 32) + (*(long*)Array_unsigned_long_258ul_Index_cpunpn.Invoke(&This->Val, num8) & 0xFFFFFFFFL);
						*(long*)BigInt_16512ul_false_unsigned_long_Index_jsva56.Invoke(&bigInt_q8g, num8) = num21;
					}
					else
					{
						long num22 = num7;
						*(long*)BigInt_16512ul_false_unsigned_long_Index_jsva56.Invoke(&bigInt_q8g, num8) = num22;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num13);
					Llvm_lifetime_end_p0.Invoke(8L, &num12);
				}
				else
				{
					long num23 = num7;
					*(long*)BigInt_16512ul_false_unsigned_long_Index_jsva56.Invoke(&bigInt_q8g, num8) = num23;
				}
				for (; (ulong)num8 > 0uL; num8 += -1L)
				{
					long num24 = *(long*)Array_unsigned_long_258ul_Index_cpunpn.Invoke(&This->Val, num8 - 1L);
					*(long*)BigInt_16512ul_false_unsigned_long_Index_jsva56.Invoke(&bigInt_q8g, num8 - 1L) = num24;
				}
				Llvm_memcpy_p0_p0_i64.Invoke(This, &bigInt_q8g3, 2064L, isVolatile: false);
				Optional_BigInt_16512ul_false_unsigned_long_Constructor.Invoke(Agg_result, &bigInt_q8g);
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				Llvm_lifetime_end_p0.Invoke(8L, &num);
				Llvm_lifetime_end_p0.Invoke(2064L, &bigInt_q8g3);
			}
			Llvm_lifetime_end_p0.Invoke(2064L, &bigInt_q8g);
		}
	}
}
