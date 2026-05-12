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
		double x2 = 0.0;
		double num5 = 0.0;
		double a = 0.0;
		double a2 = 0.0;
		long x3 = 0L;
		double y = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		double num6 = 0.0;
		double x4 = 0.0;
		double num7 = 0.0;
		NumberPair numberPair = default(NumberPair);
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num8 = 0.0;
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num9 = 0.0;
		double num10 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1023;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb8.val);
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq3, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
			bool num11 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double.Invoke(fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.val, fputil_internal_FPRepImpl_ucubaq3.FPRepSem.FPStorage.val), expected: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			if (num11)
			{
				result = 0.0;
			}
			else
			{
				long num12 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal_Sign.Invoke(anon_izyfb9.val);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
				bool num13 = (ulong)num12 < (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				int value;
				if (num13)
				{
					value = -1;
				}
				else
				{
					long num14 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal_Sign.Invoke(anon_izyfb10.val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
					value = (((ulong)num14 > (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5))) ? 1 : 0);
				}
				bool num15 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((byte)value != 0, expected: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				if (!num15)
				{
					goto IL_04dc;
				}
				if (x == 0.0)
				{
					fputil_set_errno_if_required_int.Invoke(34);
					fputil_raise_except_if_required_int.Invoke(4);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_NEG.Pointer, 1L, isVolatile: false);
					long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb11.val);
					fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val4;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				}
				else if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) && !fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					long val5 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb12.val, 0L);
					fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val5;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm7);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				}
				else
				{
					if (!fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)))
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm8, x * 4503599627370496.0);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm8, 8L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						num2 = checked(num2 - 52);
						num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
						goto IL_04dc;
					}
					result = x;
				}
			}
			goto IL_0d0a;
		}
		IL_0d0a:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_0bcb:
		result = anonymous_namespace_log10_accurate_int_int_double.Invoke(num2, num4, num6);
		goto IL_0bd8;
		IL_04dc:
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = (int)(num >>> 45);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 & 0x7F;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			long num16 = num4;
			x2 = ((double*)RD.Pointer)[num16];
		}
		num2 += unchecked((int)(num + 35184372088832L >>> 52));
		llvm_lifetime_start_p0.Invoke(8L, &num5);
		num5 = num2;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		double x5 = num5;
		long num17 = num4;
		unchecked
		{
			a = fputil_multiply_add_double_double_double.Invoke(x5, 0.6931471805598903, ((NumberPair*)LOG_R_DD.Pointer)[num17].hi);
			llvm_lifetime_start_p0.Invoke(8L, &a2);
			double x6 = num5;
			long num18 = num4;
			a2 = fputil_multiply_add_double_double_double.Invoke(x6, 5.497923018708371E-14, ((NumberPair*)LOG_R_DD.Pointer)[num18].lo);
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = (num & 0xFFFFFFFFFFFFFL) | 0x3FF0000000000000L;
			llvm_lifetime_start_p0.Invoke(8L, &y);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm9, x3);
			double num19 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm9);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			y = num19;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &x4);
			x4 = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = double.NaN;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair);
			num6 = fputil_multiply_add_double_double_double.Invoke(x2, y, -1.0);
			x4 = num6 * num6;
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num6, ((double*)LOG_COEFFS_32.Pointer)[1], *(double*)LOG_COEFFS_32.Pointer);
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num6, ((double*)LOG_COEFFS_32.Pointer)[3L], ((double*)LOG_COEFFS_32.Pointer)[2L]);
			llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = fputil_multiply_add_double_double_double.Invoke(num6, ((double*)LOG_COEFFS_32.Pointer)[5L], ((double*)LOG_COEFFS_32.Pointer)[4L]);
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double.Invoke(x4, a2, a_yc74sk, a_ijazrn, a_889uw);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_add_true_double_double.Invoke(a, num6);
			NumberPair* num20 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num20 = struct_4ydhja2.field_0;
			byte* num21 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num21 = struct_4ydhja3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			numberPair.lo += num8;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, anonymous_namespace_LOG10_E.Pointer);
			NumberPair* num22 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num22 = struct_4ydhja5.field_0;
			byte* num23 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num23 = struct_4ydhja6.field_1;
			num7 = fputil_multiply_add_double_double_double.Invoke(x4, 4.440892098500626E-16, 2.5849394142282115E-26);
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = numberPair3.hi + (numberPair3.lo - num7);
			llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = numberPair3.hi + (numberPair3.lo + num7);
			if (num9 == num10)
			{
				result = num9;
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num & 0x3FFFFFL) == 0L, expected: false))
			{
				long num24 = num;
				if (num24 != 4621819117588971520L)
				{
					if (num24 != 4636737291354636288L)
					{
						if (num24 != 4652007308841189376L)
						{
							if (num24 != 4666723172467343360L)
							{
								if (num24 != 4681608360884174848L)
								{
									if (num24 != 4696837146684686336L)
									{
										if (num24 != 4711630319722168320L)
										{
											if (num24 != 4726483295884279808L)
											{
												if (num24 != 4741671816366391296L)
												{
													if (num24 != 4756540486875873280L)
													{
														if (num24 != 4771362005757984768L)
														{
															if (num24 != 4786511204640096256L)
															{
																if (num24 != 4801453603149578240L)
																{
																	goto IL_0bcb;
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
				long num25 = num;
				if (num25 != 4816244402031689728L)
				{
					if (num25 != 4831355200913801216L)
					{
						if (num25 != 4846369599423283200L)
						{
							if (num25 != 4861130398305394688L)
							{
								if (num25 != 4876203697187506176L)
								{
									if (num25 != 4891288408196988160L)
									{
										if (num25 != 4906019910204099648L)
										{
											if (num25 != 4921056587992461136L)
											{
												if (num25 != 4936209963552724370L)
												{
													goto IL_0bcb;
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
			goto IL_0bd8;
		}
		IL_0bd8:
		llvm_lifetime_end_p0.Invoke(8L, &num10);
		llvm_lifetime_end_p0.Invoke(8L, &num9);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
		llvm_lifetime_end_p0.Invoke(8L, &num8);
		llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
		llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
		llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		llvm_lifetime_end_p0.Invoke(8L, &num7);
		llvm_lifetime_end_p0.Invoke(8L, &x4);
		llvm_lifetime_end_p0.Invoke(8L, &num6);
		llvm_lifetime_end_p0.Invoke(8L, &y);
		llvm_lifetime_end_p0.Invoke(8L, &x3);
		llvm_lifetime_end_p0.Invoke(8L, &a2);
		llvm_lifetime_end_p0.Invoke(8L, &a);
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(8L, &x2);
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0d0a;
	}
}
