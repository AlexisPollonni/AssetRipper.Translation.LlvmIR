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
	public unsafe static double Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_syracv* This)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		long num2 = 0L;
		int num3 = 0;
		double num4 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double num5 = 0.0;
		double num6 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		sbyte b = 0;
		int num7 = 0;
		int num8 = 0;
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		double num9 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs2 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs3 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs4 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs5 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		sbyte b2 = 0;
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs6 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		sbyte b3 = 0;
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs7 = default(Llvm_libc_20_1_2_BigInt_555ggs);
		int num10 = 0;
		double x = 0.0;
		int num11 = 0;
		double num12 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		double num13 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm6 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm7 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm8 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		double num14 = 0.0;
		long num15 = 0L;
		long num16 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm9 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm10 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double result;
		if (Details_expects_bool_condition_bool.Invoke(BigInt_64ul_false_unsigned_long_is_zero.Invoke(&This->Mantissa), Expected: false))
		{
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb.Val);
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
			result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 53;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 0L;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = This->Exponent + 1086;
			unchecked
			{
				if (Details_expects_bool_condition_bool.Invoke(num3 > 2046, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &This->Sign, 1L, isVolatile: false);
					long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(anon_izyfb2.Val, 2046L, 0L);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					double num17 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					num4 = num17;
					Llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = 2.0;
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = num5 * num4;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3, num6);
					bool num18 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					if (num18)
					{
						Fputil_set_errno_if_required.Invoke(34);
					}
					result = num6;
					Llvm_lifetime_end_p0.Invoke(8L, &num6);
					Llvm_lifetime_end_p0.Invoke(8L, &num5);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = 11;
					if (Details_expects_bool_condition_bool.Invoke(num3 <= 0, Expected: false))
					{
						b = 1;
						num7 = (int)(11L + (long)(uint)checked(1 - num3));
						num3 = 1023;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = checked(num3 - 53 - 1);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs) = -6148914691236517206L;
					if ((ulong)(uint)num7 >= 64uL)
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, 0);
					}
					else
					{
						long data = BigInt_64ul_false_unsigned_long_RightShift.Invoke(&This->Mantissa, (uint)num7);
						*(long*)(&llvm_libc_20_1_2_BigInt_555ggs.Val.Data) = data;
					}
					Llvm_lifetime_start_p0.Invoke(8L, &num9);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &This->Sign, 1L, isVolatile: false);
					long val3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: num3, Mantissa: (BigInt_64ul_false_unsigned_long_Unsigned_long_unsigned_long.Invoke(&llvm_libc_20_1_2_BigInt_555ggs) & 0xFFFFFFFFFFFFFL) | 0L, Sign: anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					double num19 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
					num9 = num19;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs2) = -6148914691236517206L;
					bool num20 = (ulong)(uint)num7 > 64uL;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs3);
					if (num20)
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, 0);
					}
					else
					{
						BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs3, 1);
						long data2 = BigInt_64ul_false_unsigned_long_LeftShift.Invoke(&llvm_libc_20_1_2_BigInt_555ggs3, (uint)(num7 - 1));
						*(long*)(&llvm_libc_20_1_2_BigInt_555ggs2.Val.Data) = data2;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs3);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs4);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs4) = -6148914691236517206L;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs5);
					BigInt_64ul_false_unsigned_long_BigInt_int_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs5, 1);
					long data3 = BigInt_64ul_false_unsigned_long_Subtract_dhppwb.Invoke(&llvm_libc_20_1_2_BigInt_555ggs2, &llvm_libc_20_1_2_BigInt_555ggs5);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs4.Val.Data) = data3;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs5);
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs6);
					long data4 = Llvm_libc_20_1_2_BitwiseAnd.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_555ggs2);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs6.Val.Data) = data4;
					int num21 = (BigInt_64ul_false_unsigned_long_is_zero.Invoke(&llvm_libc_20_1_2_BigInt_555ggs6) ? 1 : 0) ^ -1;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs6);
					b2 = (sbyte)(byte)num21;
					Llvm_lifetime_start_p0.Invoke(1L, &b3);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs7);
					long data5 = Llvm_libc_20_1_2_BitwiseAnd.Invoke(&This->Mantissa, &llvm_libc_20_1_2_BigInt_555ggs4);
					*(long*)(&llvm_libc_20_1_2_BigInt_555ggs7.Val.Data) = data5;
					int num22 = (BigInt_64ul_false_unsigned_long_is_zero.Invoke(&llvm_libc_20_1_2_BigInt_555ggs7) ? 1 : 0) ^ -1;
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs7);
					b3 = (sbyte)(byte)num22;
					Llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = checked((((b2 & 1) == 1) ? 1 : 0) * 2 + (((b3 & 1) == 1) ? 1 : 0));
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = double.NaN;
					if (Details_expects_bool_condition_bool.Invoke(num8 <= 0, Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num11);
						checked
						{
							num11 = 1 - num8;
							Llvm_lifetime_start_p0.Invoke(8L, &num12);
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							long val4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: 1023 + num11, Sign: anon_izyfb4.Val, Mantissa: 0L);
							llvm_libc_20_1_2_fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val4;
							double num23 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
							num12 = num23;
							Llvm_lifetime_start_p0.Invoke(8L, &num13);
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							long val5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: 1023 - num11, Sign: anon_izyfb5.Val, Mantissa: 0L);
							llvm_libc_20_1_2_fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val5;
							double num24 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
							num13 = num24;
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &This->Sign, 1L, isVolatile: false);
							long val6 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: num8 + num11, Sign: anon_izyfb6.Val, Mantissa: 0L);
							llvm_libc_20_1_2_fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.Val = val6;
							x = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
							result = Fputil_multiply_add_double.Invoke(x, num10, num9 * num12) * num13;
							Llvm_lifetime_end_p0.Invoke(8L, &num13);
							Llvm_lifetime_end_p0.Invoke(8L, &num12);
							Llvm_lifetime_end_p0.Invoke(4L, &num11);
						}
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, &This->Sign, 1L, isVolatile: false);
						long val7 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value.Invoke(Biased_exp: num8, Sign: anon_izyfb7.Val, Mantissa: 0L);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val7;
						x = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
						Llvm_lifetime_start_p0.Invoke(8L, &num14);
						num14 = Fputil_multiply_add_double.Invoke(x, num10, num9);
						if (Details_expects_bool_condition_bool.Invoke((b & 1) == 1, Expected: false))
						{
							Llvm_lifetime_start_p0.Invoke(8L, &num15);
							num15 = (long)num3 << 52;
							Llvm_lifetime_start_p0.Invoke(8L, &num16);
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
							FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9, num14);
							long num25 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9)) - num15;
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
							num16 = num25;
							if ((num16 & 0x7FF0000000000000L) == 0L)
							{
								num16 -= 0L;
								if (num10 != 0)
								{
									Fputil_set_errno_if_required.Invoke(34);
									Fputil_raise_except_if_required.Invoke(16);
								}
							}
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
							FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm10, num16);
							result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
							Llvm_lifetime_end_p0.Invoke(8L, &num16);
							Llvm_lifetime_end_p0.Invoke(8L, &num15);
						}
						else
						{
							result = num14;
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num14);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(4L, &num10);
					Llvm_lifetime_end_p0.Invoke(1L, &b3);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs4);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs2);
					Llvm_lifetime_end_p0.Invoke(8L, &num9);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_BigInt_555ggs);
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
		return result;
	}
}
