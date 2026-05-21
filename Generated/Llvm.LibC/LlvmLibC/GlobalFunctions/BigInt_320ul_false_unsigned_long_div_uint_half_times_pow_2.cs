using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_div_uint_half_times_pow_2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmE25div_uint_half_times_pow_2Ejm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::div_uint_half_times_pow_2(unsigned int, unsigned long)")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_cpp_optional_t82b4p* Agg_result, [MangledName("this")] Llvm_libc_20_1_2_BigInt_76gxx6* This, [MangledName("x")] int X, [MangledName("e")] long E)
	{
		Llvm_libc_20_1_2_BigInt_76gxx6 llvm_libc_20_1_2_BigInt_76gxx = default(Llvm_libc_20_1_2_BigInt_76gxx6);
		Llvm_libc_20_1_2_BigInt_76gxx6 llvm_libc_20_1_2_BigInt_76gxx2 = default(Llvm_libc_20_1_2_BigInt_76gxx6);
		Llvm_libc_20_1_2_BigInt_76gxx6 llvm_libc_20_1_2_BigInt_76gxx3 = default(Llvm_libc_20_1_2_BigInt_76gxx6);
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
		Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, 0, 40L, isVolatile: false);
		InlineArray5_Int64* ptr = &llvm_libc_20_1_2_BigInt_76gxx.Val.Data;
		unchecked
		{
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			((long*)ptr)[2] = -6148914691236517206L;
			((long*)ptr)[3] = -6148914691236517206L;
			((long*)ptr)[4] = -6148914691236517206L;
			BigInt_320ul_false_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_76gxx);
			if (X == 0)
			{
				Optional_BigInt_320ul_false_unsigned_long_Constructor.Invoke(Agg_result);
			}
			else if ((ulong)E >= 320uL)
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, This, 40L, isVolatile: false);
				Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx2);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_76gxx2, 0, 40L, isVolatile: false);
				BigInt_320ul_false_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_76gxx2);
				Llvm_memcpy_p0_p0_i64.Invoke(This, &llvm_libc_20_1_2_BigInt_76gxx2, 40L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx2);
				Optional_BigInt_320ul_false_unsigned_long_Constructor.Invoke(Agg_result, &llvm_libc_20_1_2_BigInt_76gxx);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx3);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_76gxx3, 0, 40L, isVolatile: false);
				InlineArray5_Int64* ptr2 = &llvm_libc_20_1_2_BigInt_76gxx3.Val.Data;
				*(long*)ptr2 = -6148914691236517206L;
				((long*)ptr2)[1] = -6148914691236517206L;
				((long*)ptr2)[2] = -6148914691236517206L;
				((long*)ptr2)[3] = -6148914691236517206L;
				((long*)ptr2)[4] = -6148914691236517206L;
				BigInt_320ul_false_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_76gxx3);
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
				num8 = 5L;
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				for (num9 = 5L - num6; (ulong)num9 > 0uL; num9 += -1L)
				{
					num7 <<= 32;
					Llvm_libc_20_1_2_cpp_array_msasyg* val = &This->Val;
					long num14 = num8 + -1L;
					num8 = num14;
					long num15 = *(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke(val, num14) >>> 32;
					num7 += num15;
					Llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = (long)((ulong)num7 / (ulong)num);
					num7 = (long)((ulong)num7 % (ulong)num);
					num7 <<= 32;
					long num16 = *(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke(&This->Val, num8) & 0xFFFFFFFFL;
					num7 += num16;
					long num17 = (num10 << 32) + (long)((ulong)num7 / (ulong)num);
					*(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke(&llvm_libc_20_1_2_BigInt_76gxx3.Val, num9 - 1L) = num17;
					num7 = (long)((ulong)num7 % (ulong)num);
					Llvm_lifetime_end_p0.Invoke(8L, &num10);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = num5 - E;
				if ((ulong)num11 > 0uL)
				{
					BigInt_320ul_false_unsigned_long_Operator.Invoke(&llvm_libc_20_1_2_BigInt_76gxx3, num11);
					Llvm_lifetime_start_p0.Invoke(8L, &num12);
					num12 = 0L;
					Llvm_lifetime_start_p0.Invoke(8L, &num13);
					Llvm_libc_20_1_2_cpp_array_msasyg* val2 = &This->Val;
					long num18 = num8 + -1L;
					num8 = num18;
					num13 = *(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke(val2, num18);
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
					*(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke(&llvm_libc_20_1_2_BigInt_76gxx3.Val, 0L) += num19;
					if ((ulong)(num5 - E) <= 32uL)
					{
						if ((ulong)num8 < 4uL)
						{
							long num20 = num7 >>> 32;
							*(long*)BigInt_320ul_false_unsigned_long_Index.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, num8 + 1L) = num20;
						}
						long num21 = (num7 << 32) + (*(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke(&This->Val, num8) & 0xFFFFFFFFL);
						*(long*)BigInt_320ul_false_unsigned_long_Index.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, num8) = num21;
					}
					else
					{
						long num22 = num7;
						*(long*)BigInt_320ul_false_unsigned_long_Index.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, num8) = num22;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num13);
					Llvm_lifetime_end_p0.Invoke(8L, &num12);
				}
				else
				{
					long num23 = num7;
					*(long*)BigInt_320ul_false_unsigned_long_Index.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, num8) = num23;
				}
				for (; (ulong)num8 > 0uL; num8 += -1L)
				{
					long num24 = *(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke(&This->Val, num8 - 1L);
					*(long*)BigInt_320ul_false_unsigned_long_Index.Invoke(&llvm_libc_20_1_2_BigInt_76gxx, num8 - 1L) = num24;
				}
				Llvm_memcpy_p0_p0_i64.Invoke(This, &llvm_libc_20_1_2_BigInt_76gxx3, 40L, isVolatile: false);
				Optional_BigInt_320ul_false_unsigned_long_Constructor.Invoke(Agg_result, &llvm_libc_20_1_2_BigInt_76gxx);
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				Llvm_lifetime_end_p0.Invoke(8L, &num);
				Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx3);
			}
			Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_BigInt_76gxx);
		}
	}
}
