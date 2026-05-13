using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmE25div_uint_half_times_pow_2Ejm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::div_uint_half_times_pow_2(unsigned int, unsigned long)")]
internal static partial class BigInt_16512ul_false_unsigned_long_div_uint_half_times_pow_2_unsigned_int_unsigned_long
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_tchbah* agg_result, BigInt_k36xhe* @this, int x, long e)
	{
		BigInt_k36xhe bigInt_k36xhe = default(BigInt_k36xhe);
		BigInt_k36xhe bigInt_k36xhe2 = default(BigInt_k36xhe);
		BigInt_k36xhe bigInt_k36xhe3 = default(BigInt_k36xhe);
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
		llvm_lifetime_start_p0.Invoke(2064L, &bigInt_k36xhe);
		llvm_memset_p0_i64.Invoke(&bigInt_k36xhe, -86, 2064L, isVolatile: false);
		BigInt_16512ul_false_unsigned_long_BigInt.Invoke(&bigInt_k36xhe);
		unchecked
		{
			if (x == 0)
			{
				cpp_optional_BigInt_16512ul_false_unsigned_long_optional_cpp_nullopt_t.Invoke(agg_result);
			}
			else if ((ulong)e >= 16512uL)
			{
				llvm_memcpy_p0_p0_i64.Invoke(&bigInt_k36xhe, @this, 2064L, isVolatile: false);
				llvm_lifetime_start_p0.Invoke(2064L, &bigInt_k36xhe2);
				llvm_memset_p0_i64.Invoke(&bigInt_k36xhe2, 0, 2064L, isVolatile: false);
				BigInt_16512ul_false_unsigned_long_BigInt.Invoke(&bigInt_k36xhe2);
				llvm_memcpy_p0_p0_i64.Invoke(@this, &bigInt_k36xhe2, 2064L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(2064L, &bigInt_k36xhe2);
				cpp_optional_BigInt_16512ul_false_unsigned_long_optional_BigInt_16512ul_false_unsigned_long.Invoke(agg_result, &bigInt_k36xhe);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2064L, &bigInt_k36xhe3);
				llvm_memset_p0_i64.Invoke(&bigInt_k36xhe3, -86, 2064L, isVolatile: false);
				BigInt_16512ul_false_unsigned_long_BigInt.Invoke(&bigInt_k36xhe3);
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = (uint)x;
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 6L;
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = 32L;
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = 4294967295L;
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = (e >>> 6) + (((e & 0x3FL) != 0L) ? 1L : 0L) << 6;
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = (long)((ulong)num5 / 64uL);
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = 258L;
				llvm_lifetime_start_p0.Invoke(8L, &num9);
				for (num9 = 258L - num6; (ulong)num9 > 0uL; num9 += -1L)
				{
					num7 <<= 32;
					cpp_array_vnnqx8* val = &@this->val;
					long num14 = num8 + -1L;
					num8 = num14;
					long num15 = *(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(val, num14) >>> 32;
					num7 += num15;
					llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = (long)((ulong)num7 / (ulong)num);
					num7 = (long)((ulong)num7 % (ulong)num);
					num7 <<= 32;
					long num16 = *(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(&@this->val, num8) & 0xFFFFFFFFL;
					num7 += num16;
					long num17 = (num10 << 32) + (long)((ulong)num7 / (ulong)num);
					*(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(&bigInt_k36xhe3.val, num9 - 1L) = num17;
					num7 = (long)((ulong)num7 % (ulong)num);
					llvm_lifetime_end_p0.Invoke(8L, &num10);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num9);
				llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = num5 - e;
				if ((ulong)num11 > 0uL)
				{
					BigInt_16512ul_false_unsigned_long_operator_unsigned_long_en4bet.Invoke(&bigInt_k36xhe3, num11);
					llvm_lifetime_start_p0.Invoke(8L, &num12);
					num12 = 0L;
					llvm_lifetime_start_p0.Invoke(8L, &num13);
					cpp_array_vnnqx8* val2 = &@this->val;
					long num18 = num8 + -1L;
					num8 = num18;
					num13 = *(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(val2, num18);
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
					*(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(&bigInt_k36xhe3.val, 0L) += num19;
					if ((ulong)(num5 - e) <= 32uL)
					{
						if ((ulong)num8 < 257uL)
						{
							long num20 = num7 >>> 32;
							*(long*)BigInt_16512ul_false_unsigned_long_operator_unsigned_long_jsva56.Invoke(&bigInt_k36xhe, num8 + 1L) = num20;
						}
						long num21 = (num7 << 32) + (*(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(&@this->val, num8) & 0xFFFFFFFFL);
						*(long*)BigInt_16512ul_false_unsigned_long_operator_unsigned_long_jsva56.Invoke(&bigInt_k36xhe, num8) = num21;
					}
					else
					{
						long num22 = num7;
						*(long*)BigInt_16512ul_false_unsigned_long_operator_unsigned_long_jsva56.Invoke(&bigInt_k36xhe, num8) = num22;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num13);
					llvm_lifetime_end_p0.Invoke(8L, &num12);
				}
				else
				{
					long num23 = num7;
					*(long*)BigInt_16512ul_false_unsigned_long_operator_unsigned_long_jsva56.Invoke(&bigInt_k36xhe, num8) = num23;
				}
				for (; (ulong)num8 > 0uL; num8 += -1L)
				{
					long num24 = *(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(&@this->val, num8 - 1L);
					*(long*)BigInt_16512ul_false_unsigned_long_operator_unsigned_long_jsva56.Invoke(&bigInt_k36xhe, num8 - 1L) = num24;
				}
				llvm_memcpy_p0_p0_i64.Invoke(@this, &bigInt_k36xhe3, 2064L, isVolatile: false);
				cpp_optional_BigInt_16512ul_false_unsigned_long_optional_BigInt_16512ul_false_unsigned_long.Invoke(agg_result, &bigInt_k36xhe);
				llvm_lifetime_end_p0.Invoke(8L, &num11);
				llvm_lifetime_end_p0.Invoke(8L, &num8);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				llvm_lifetime_end_p0.Invoke(8L, &num);
				llvm_lifetime_end_p0.Invoke(2064L, &bigInt_k36xhe3);
			}
			llvm_lifetime_end_p0.Invoke(2064L, &bigInt_k36xhe);
		}
	}
}
