using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_div_uint_half_times_pow_2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE25div_uint_half_times_pow_2Ejm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::div_uint_half_times_pow_2(unsigned int, unsigned long)")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_cpp_optional_neprgb* Agg_result, [MangledName("this")] Anon_izyfb7* This, [MangledName("x")] int X, [MangledName("e")] long E)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh2 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh3 = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
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
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			BigInt_128ul_false_unsigned_long_Constructor.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh));
			if (X == 0)
			{
				Optional_BigInt_128ul_false_unsigned_long_Constructor.Invoke(Agg_result);
			}
			else if ((ulong)E >= 128uL)
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh, This, 16L, isVolatile: false);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh2, 0, 16L, isVolatile: false);
				BigInt_128ul_false_unsigned_long_Constructor.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh2));
				Llvm_memcpy_p0_p0_i64.Invoke(This, &llvm_libc_20_1_2_BigInt_qdkjbh2, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh2);
				Optional_BigInt_128ul_false_unsigned_long_Constructor.Invoke(Agg_result, (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh));
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh3);
				*(long*)ptr2 = -6148914691236517206L;
				((long*)ptr2)[1] = -6148914691236517206L;
				BigInt_128ul_false_unsigned_long_Constructor.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3));
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
				num8 = 2L;
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				for (num9 = 2L - num6; (ulong)num9 > 0uL; num9 += -1L)
				{
					num7 <<= 32;
					Llvm_libc_20_1_2_cpp_array_i3937k* val = &((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val;
					long num14 = num8 + -1L;
					num8 = num14;
					long num15 = *(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(val, num14) >>> 32;
					num7 += num15;
					Llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = (long)((ulong)num7 / (ulong)num);
					num7 = (long)((ulong)num7 % (ulong)num);
					num7 <<= 32;
					long num16 = *(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val, num8) & 0xFFFFFFFFL;
					num7 += num16;
					long num17 = (num10 << 32) + (long)((ulong)num7 / (ulong)num);
					*(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh3.Val, num9 - 1L) = num17;
					num7 = (long)((ulong)num7 % (ulong)num);
					Llvm_lifetime_end_p0.Invoke(8L, &num10);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = num5 - E;
				if ((ulong)num11 > 0uL)
				{
					BigInt_128ul_false_unsigned_long_Operator_89tuvz.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh3), num11);
					Llvm_lifetime_start_p0.Invoke(8L, &num12);
					num12 = 0L;
					Llvm_lifetime_start_p0.Invoke(8L, &num13);
					Llvm_libc_20_1_2_cpp_array_i3937k* val2 = &((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val;
					long num18 = num8 + -1L;
					num8 = num18;
					num13 = *(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(val2, num18);
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
					*(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh3.Val, 0L) += num19;
					if ((ulong)(num5 - E) <= 32uL)
					{
						if ((ulong)num8 < 1uL)
						{
							long num20 = num7 >>> 32;
							*(long*)BigInt_128ul_false_unsigned_long_Index_4bextd.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), num8 + 1L) = num20;
						}
						long num21 = (num7 << 32) + (*(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val, num8) & 0xFFFFFFFFL);
						*(long*)BigInt_128ul_false_unsigned_long_Index_4bextd.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), num8) = num21;
					}
					else
					{
						long num22 = num7;
						*(long*)BigInt_128ul_false_unsigned_long_Index_4bextd.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), num8) = num22;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num13);
					Llvm_lifetime_end_p0.Invoke(8L, &num12);
				}
				else
				{
					long num23 = num7;
					*(long*)BigInt_128ul_false_unsigned_long_Index_4bextd.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), num8) = num23;
				}
				for (; (ulong)num8 > 0uL; num8 += -1L)
				{
					long num24 = *(long*)Array_unsigned_long_2ul_Index_6dk93t.Invoke(&((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val, num8 - 1L);
					*(long*)BigInt_128ul_false_unsigned_long_Index_4bextd.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), num8 - 1L) = num24;
				}
				Llvm_memcpy_p0_p0_i64.Invoke(This, &llvm_libc_20_1_2_BigInt_qdkjbh3, 16L, isVolatile: false);
				Optional_BigInt_128ul_false_unsigned_long_Constructor.Invoke(Agg_result, (Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh));
				Llvm_lifetime_end_p0.Invoke(8L, &num11);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				Llvm_lifetime_end_p0.Invoke(8L, &num);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh3);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
		}
	}
}
