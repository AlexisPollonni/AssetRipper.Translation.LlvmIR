using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class log10
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq3 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		int num3 = 0;
		int num4 = 0;
		double num5 = 0.0;
		double num6 = 0.0;
		double a = 0.0;
		double a2 = 0.0;
		long num7 = 0L;
		double num8 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		double num9 = 0.0;
		double x2 = 0.0;
		double num10 = 0.0;
		NumberPair numberPair = default(NumberPair);
		long x3 = 0L;
		double num11 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num12 = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num13 = 0.0;
		double num14 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1023;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb8.val);
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq3, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
			bool num15 = details_expects_bool_condition_bool.Invoke(internal_Equals_r4buia.Invoke(fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.val, fputil_internal_FPRepImpl_ucubaq3.FPRepSem.FPStorage.val), expected: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			if (num15)
			{
				result = 0.0;
			}
			else
			{
				long num16 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal.Invoke(anon_izyfb9.val);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
				bool num17 = (ulong)num16 < (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				int value;
				if (num17)
				{
					value = -1;
				}
				else
				{
					long num18 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb10.val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
					value = (((ulong)num18 > (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5))) ? 1 : 0);
				}
				bool num19 = details_expects_bool_condition_bool.Invoke((byte)value != 0, expected: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				if (!num19)
				{
					goto IL_04f3;
				}
				if (x == 0.0)
				{
					fputil_set_errno_if_required.Invoke(34);
					fputil_raise_except_if_required.Invoke(4);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_NEG.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb11.val);
					fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val4;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				}
				else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) && !FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					fputil_set_errno_if_required.Invoke(33);
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					long val5 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb12.val, 0L);
					fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val5;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				}
				else
				{
					if (!FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)))
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm8, x * 4503599627370496.0);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm8, 8L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						num2 = checked(num2 - 52);
						num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
						goto IL_04f3;
					}
					result = x;
				}
			}
			goto IL_0db5;
		}
		IL_0db5:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_0c56:
		result = anonymous_namespace_log10_accurate.Invoke(num2, num4, num9);
		goto IL_0c63;
		IL_04f3:
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = (int)(num >>> 45);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 & 0x7F;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			long num20 = num4;
			num5 = ((double*)RD.Pointer)[num20];
		}
		num2 += unchecked((int)(num + 35184372088832L >>> 52));
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = num2;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		double x4 = num6;
		long num21 = num4;
		unchecked
		{
			a = fputil_multiply_add_double.Invoke(x4, 0.6931471805598903, ((NumberPair*)LOG_R_DD.Pointer)[num21].hi);
			llvm_lifetime_start_p0.Invoke(8L, &a2);
			double x5 = num6;
			long num22 = num4;
			a2 = fputil_multiply_add_double.Invoke(x5, 5.497923018708371E-14, ((NumberPair*)LOG_R_DD.Pointer)[num22].lo);
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = (num & 0xFFFFFFFFFFFFFL) | 0x3FF0000000000000L;
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm9, num7);
			double num23 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm9);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			num8 = num23;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = double.NaN;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = num7 & 0x3FFFE00000000000L;
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm10, x3);
			double num24 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm10);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			num11 = num24;
			double x6 = num5;
			double y = num8 - num11;
			long num25 = num4;
			num9 = fputil_multiply_add_double.Invoke(x6, y, ((double*)CD.Pointer)[num25]);
			x2 = num9 * num9;
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double.Invoke(num9, ((double*)LOG_COEFFS_32.Pointer)[1], *(double*)LOG_COEFFS_32.Pointer);
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double.Invoke(num9, ((double*)LOG_COEFFS_32.Pointer)[3L], ((double*)LOG_COEFFS_32.Pointer)[2L]);
			llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = fputil_multiply_add_double.Invoke(num9, ((double*)LOG_COEFFS_32.Pointer)[5L], ((double*)LOG_COEFFS_32.Pointer)[4L]);
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = fputil_polyeval_double_double_double_double.Invoke(x2, a2, a_yc74sk, a_ijazrn, a_889uw);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			Struct_4ydhja struct_4ydhja = fputil_exact_add_true.Invoke(a, num9);
			NumberPair* num26 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num26 = struct_4ydhja2.field_0;
			byte* num27 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num27 = struct_4ydhja3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			numberPair.lo += num12;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = fputil_quick_mult_27ul.Invoke(&numberPair, anonymous_namespace_LOG10_E.Pointer);
			NumberPair* num28 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num28 = struct_4ydhja5.field_0;
			byte* num29 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num29 = struct_4ydhja6.field_1;
			num10 = fputil_multiply_add_double.Invoke(x2, 4.440892098500626E-16, 2.5849394142282115E-26);
			llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = numberPair3.hi + (numberPair3.lo - num10);
			llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = numberPair3.hi + (numberPair3.lo + num10);
			if (num13 == num14)
			{
				result = num13;
			}
			else if (details_expects_bool_condition_bool.Invoke((num & 0x3FFFFFL) == 0L, expected: false))
			{
				long num30 = num;
				if (num30 != 4621819117588971520L)
				{
					if (num30 != 4636737291354636288L)
					{
						if (num30 != 4652007308841189376L)
						{
							if (num30 != 4666723172467343360L)
							{
								if (num30 != 4681608360884174848L)
								{
									if (num30 != 4696837146684686336L)
									{
										if (num30 != 4711630319722168320L)
										{
											if (num30 != 4726483295884279808L)
											{
												if (num30 != 4741671816366391296L)
												{
													if (num30 != 4756540486875873280L)
													{
														if (num30 != 4771362005757984768L)
														{
															if (num30 != 4786511204640096256L)
															{
																if (num30 != 4801453603149578240L)
																{
																	goto IL_0c56;
																}
																result = 13.0;
															}
															else
															{
																result = 12.0;
															}
														}
														else
														{
															result = 11.0;
														}
													}
													else
													{
														result = 10.0;
													}
												}
												else
												{
													result = 9.0;
												}
											}
											else
											{
												result = 8.0;
											}
										}
										else
										{
											result = 7.0;
										}
									}
									else
									{
										result = 6.0;
									}
								}
								else
								{
									result = 5.0;
								}
							}
							else
							{
								result = 4.0;
							}
						}
						else
						{
							result = 3.0;
						}
					}
					else
					{
						result = 2.0;
					}
				}
				else
				{
					result = 1.0;
				}
			}
			else
			{
				long num31 = num;
				if (num31 != 4816244402031689728L)
				{
					if (num31 != 4831355200913801216L)
					{
						if (num31 != 4846369599423283200L)
						{
							if (num31 != 4861130398305394688L)
							{
								if (num31 != 4876203697187506176L)
								{
									if (num31 != 4891288408196988160L)
									{
										if (num31 != 4906019910204099648L)
										{
											if (num31 != 4921056587992461136L)
											{
												if (num31 != 4936209963552724370L)
												{
													goto IL_0c56;
												}
												result = 22.0;
											}
											else
											{
												result = 21.0;
											}
										}
										else
										{
											result = 20.0;
										}
									}
									else
									{
										result = 19.0;
									}
								}
								else
								{
									result = 18.0;
								}
							}
							else
							{
								result = 17.0;
							}
						}
						else
						{
							result = 16.0;
						}
					}
					else
					{
						result = 15.0;
					}
				}
				else
				{
					result = 14.0;
				}
			}
			goto IL_0c63;
		}
		IL_0c63:
		llvm_lifetime_end_p0.Invoke(8L, &num14);
		llvm_lifetime_end_p0.Invoke(8L, &num13);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
		llvm_lifetime_end_p0.Invoke(8L, &num12);
		llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
		llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
		llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
		llvm_lifetime_end_p0.Invoke(8L, &num11);
		llvm_lifetime_end_p0.Invoke(8L, &x3);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		llvm_lifetime_end_p0.Invoke(8L, &num10);
		llvm_lifetime_end_p0.Invoke(8L, &x2);
		llvm_lifetime_end_p0.Invoke(8L, &num9);
		llvm_lifetime_end_p0.Invoke(8L, &num8);
		llvm_lifetime_end_p0.Invoke(8L, &num7);
		llvm_lifetime_end_p0.Invoke(8L, &a2);
		llvm_lifetime_end_p0.Invoke(8L, &a);
		llvm_lifetime_end_p0.Invoke(8L, &num6);
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0db5;
	}
}
