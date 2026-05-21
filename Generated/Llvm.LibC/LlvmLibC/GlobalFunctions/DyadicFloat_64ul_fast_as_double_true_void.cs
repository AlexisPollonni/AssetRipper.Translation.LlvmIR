using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_fast_as_double_true_void
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE7fast_asIdLb1EvEET_v")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::fast_as<double, true, void>() const")]
	[return: NativeType("double")]
	public unsafe static double Invoke(fputil_DyadicFloat_syracv* @this)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		double num4 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num5 = 0.0;
		double num6 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		int num7 = 0;
		int num8 = 0;
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		double num9 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		BigInt_555ggs bigInt_555ggs2 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs3 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs4 = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs5 = default(BigInt_555ggs);
		sbyte b2 = 0;
		BigInt_555ggs bigInt_555ggs6 = default(BigInt_555ggs);
		sbyte b3 = 0;
		BigInt_555ggs bigInt_555ggs7 = default(BigInt_555ggs);
		int num10 = 0;
		double x = 0.0;
		int num11 = 0;
		double num12 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		double num13 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		double num14 = 0.0;
		long num15 = 0L;
		long num16 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(fputil_FPBits_wjhbrm);
		double result;
		if (details_expects_bool_condition_bool.Invoke(BigInt_64ul_false_unsigned_long_is_zero.Invoke(&@this->mantissa), expected: false))
		{
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb8.val);
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
			result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 53;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 0L;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = @this->exponent + 1086;
			unchecked
			{
				if (details_expects_bool_condition_bool.Invoke(num3 > 2046, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &@this->sign, 1L, isVolatile: false);
					long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(anon_izyfb9.val, 2046L, 0L);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val2;
					double num17 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					num4 = num17;
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = 2.0;
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = num5 * num4;
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm4, num6);
					bool num18 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4));
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					if (num18)
					{
						fputil_set_errno_if_required.Invoke(34);
					}
					result = num6;
					llvm_lifetime_end_p0.Invoke(8L, &num6);
					llvm_lifetime_end_p0.Invoke(8L, &num5);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = 11;
					if (details_expects_bool_condition_bool.Invoke(num3 <= 0, expected: false))
					{
						b = 1;
						num7 = (int)(11L + (long)(uint)checked(1 - num3));
						num3 = 1023;
					}
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = checked(num3 - 53 - 1);
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs);
					*(long*)(&bigInt_555ggs) = -6148914691236517206L;
					if ((ulong)(uint)num7 >= 64uL)
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_555ggs, 0);
					}
					else
					{
						long data = BigInt_64ul_false_unsigned_long_RightShift.Invoke(&@this->mantissa, (uint)num7);
						*(long*)(&bigInt_555ggs.val.Data) = data;
					}
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &@this->sign, 1L, isVolatile: false);
					long val3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(biased_exp: num3, mantissa: (BigInt_64ul_false_unsigned_long_unsigned_long_unsigned_long.Invoke(&bigInt_555ggs) & 0xFFFFFFFFFFFFFL) | 0L, sign: anon_izyfb10.val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
					double num19 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					num9 = num19;
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs2);
					*(long*)(&bigInt_555ggs2) = -6148914691236517206L;
					bool num20 = (ulong)(uint)num7 > 64uL;
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs3);
					if (num20)
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_555ggs2, 0);
					}
					else
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_555ggs3, 1);
						long data2 = BigInt_64ul_false_unsigned_long_LeftShift.Invoke(&bigInt_555ggs3, (uint)(num7 - 1));
						*(long*)(&bigInt_555ggs2.val.Data) = data2;
					}
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs3);
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs4);
					*(long*)(&bigInt_555ggs4) = -6148914691236517206L;
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs5);
					BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&bigInt_555ggs5, 1);
					long data3 = BigInt_64ul_false_unsigned_long_Subtract_dhppwb.Invoke(&bigInt_555ggs2, &bigInt_555ggs5);
					*(long*)(&bigInt_555ggs4.val.Data) = data3;
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs5);
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs6);
					long data4 = BitwiseAnd.Invoke(&@this->mantissa, &bigInt_555ggs2);
					*(long*)(&bigInt_555ggs6.val.Data) = data4;
					int num21 = (BigInt_64ul_false_unsigned_long_is_zero.Invoke(&bigInt_555ggs6) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs6);
					b2 = (sbyte)(byte)num21;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs7);
					long data5 = BitwiseAnd.Invoke(&@this->mantissa, &bigInt_555ggs4);
					*(long*)(&bigInt_555ggs7.val.Data) = data5;
					int num22 = (BigInt_64ul_false_unsigned_long_is_zero.Invoke(&bigInt_555ggs7) ? 1 : 0) ^ -1;
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs7);
					b3 = (sbyte)(byte)num22;
					llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					llvm_lifetime_start_p0.Invoke(8L, &x);
					x = double.NaN;
					if (details_expects_bool_condition_bool.Invoke(num8 <= 0, expected: false))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num11);
						checked
						{
							num11 = 1 - num8;
							llvm_lifetime_start_p0.Invoke(8L, &num12);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
							long val4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(biased_exp: 1023 + num11, sign: anon_izyfb11.val, mantissa: 0L);
							fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val4;
							double num23 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							num12 = num23;
							llvm_lifetime_start_p0.Invoke(8L, &num13);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
							long val5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(biased_exp: 1023 - num11, sign: anon_izyfb12.val, mantissa: 0L);
							fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val5;
							double num24 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							num13 = num24;
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &@this->sign, 1L, isVolatile: false);
							long val6 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(biased_exp: num8 + num11, sign: anon_izyfb13.val, mantissa: 0L);
							fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val6;
							x = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
							result = fputil_multiply_add_double.Invoke(x, num10, num9 * num12) * num13;
							llvm_lifetime_end_p0.Invoke(8L, &num13);
							llvm_lifetime_end_p0.Invoke(8L, &num12);
							llvm_lifetime_end_p0.Invoke(4L, &num11);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, &@this->sign, 1L, isVolatile: false);
						long val7 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(biased_exp: num8, sign: anon_izyfb14.val, mantissa: 0L);
						fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val7;
						x = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm9);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
						llvm_lifetime_start_p0.Invoke(8L, &num14);
						num14 = fputil_multiply_add_double.Invoke(x, num10, num9);
						if (details_expects_bool_condition_bool.Invoke((b & 1) == 1, expected: false))
						{
							llvm_lifetime_start_p0.Invoke(8L, &num15);
							num15 = (long)num3 << 52;
							llvm_lifetime_start_p0.Invoke(8L, &num16);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
							FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm10, num14);
							long num25 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm10)) - num15;
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
							num16 = num25;
							if ((num16 & 0x7FF0000000000000L) == 0L)
							{
								num16 -= 0L;
								if (num10 != 0)
								{
									fputil_set_errno_if_required.Invoke(34);
									fputil_raise_except_if_required.Invoke(16);
								}
							}
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
							FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm11, num16);
							result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm11);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
							llvm_lifetime_end_p0.Invoke(8L, &num16);
							llvm_lifetime_end_p0.Invoke(8L, &num15);
						}
						else
						{
							result = num14;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num14);
					}
					llvm_lifetime_end_p0.Invoke(8L, &x);
					llvm_lifetime_end_p0.Invoke(4L, &num10);
					llvm_lifetime_end_p0.Invoke(1L, &b3);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs4);
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs2);
					llvm_lifetime_end_p0.Invoke(8L, &num9);
					llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		return result;
	}
}
