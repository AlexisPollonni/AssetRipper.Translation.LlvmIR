using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exp10
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		double num2 = 0.0;
		int num3 = 0;
		double num4 = 0.0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double z = 0.0;
		double num8 = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		double num11 = 0.0;
		long num12 = 0L;
		double num13 = 0.0;
		long num14 = 0L;
		NumberPair numberPair4 = default(NumberPair);
		double num15 = 0.0;
		double num16 = 0.0;
		long num17 = 0L;
		double num18 = 0.0;
		long num19 = 0L;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((ulong)num >= 13867491935800207938uL) ? true : (((ulong)num > 13581672830762149134uL || (ulong)num < 4644130490496809471uL) ? ((ulong)num < 4362804393534743822uL) : true), expected: false))
			{
				result = anonymous_namespace_set_exceptional_double_44.Invoke(x);
				goto IL_0b1f;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, 3.321928094887362, 3145728.0001220703);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)(cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num2) >>> 19);
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = num3;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = (num3 >> 6) & 0x3F;
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = num3 & 0x3F;
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = num3 >> 12;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			long num20 = (uint)num5;
			numberPair.lo = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num20].mid;
			long num21 = (uint)num5;
			numberPair.hi = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num21].hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			long num22 = (uint)num6;
			numberPair2.lo = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num22].mid;
			long num23 = (uint)num6;
			numberPair2.hi = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num23].hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, &numberPair2);
			NumberPair* num24 = &numberPair3;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num24 = struct_4ydhja2.field_0;
			byte* num25 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num25 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num4, -7.349365128561658E-05, x);
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num4, 4.649201285928778E-16, z);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = num8 * numberPair3.hi;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = anonymous_namespace_poly_approx_d_double_45.Invoke(num8);
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x2, y, numberPair3.lo);
			llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = numberPair3.hi + (num9 + 1.6263032587282567E-19);
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = numberPair3.hi + (num9 - 1.6263032587282567E-19);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num10 == num11, expected: true))
			{
				llvm_lifetime_start_p0.Invoke(8L, &num12);
				num12 = (long)num7 << 52;
				llvm_lifetime_start_p0.Invoke(8L, &num13);
				llvm_lifetime_start_p0.Invoke(8L, &num14);
				num14 = checked(num12 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num10));
				double num26 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num14);
				llvm_lifetime_end_p0.Invoke(8L, &num14);
				num13 = num26;
				result = num13;
				llvm_lifetime_end_p0.Invoke(8L, &num13);
				llvm_lifetime_end_p0.Invoke(8L, &num12);
			}
			else
			{
				if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((num & -9223090561878065153L) == 0L, expected: false))
				{
					goto IL_0800;
				}
				long num27 = num;
				if (num27 != 4607182418800017408L)
				{
					if (num27 != 4611686018427387904L)
					{
						if (num27 != 4613937818241073152L)
						{
							if (num27 != 4616189618054758400L)
							{
								if (num27 != 4617315517961601024L)
								{
									if (num27 != 4618441417868443648L)
									{
										if (num27 != 4619567317775286272L)
										{
											if (num27 != 4620693217682128896L)
											{
												if (num27 != 4621256167635550208L)
												{
													if (num27 != 4621819117588971520L)
													{
														if (num27 != 4622382067542392832L)
														{
															if (num27 != 4622945017495814144L)
															{
																if (num27 != 4623507967449235456L)
																{
																	if (num27 != 4624070917402656768L)
																	{
																		if (num27 != 4624633867356078080L)
																		{
																			if (num27 != 4625196817309499392L)
																			{
																				if (num27 != 4625478292286210048L)
																				{
																					if (num27 != 4625759767262920704L)
																					{
																						if (num27 != 4626041242239631360L)
																						{
																							if (num27 != 4626322717216342016L)
																							{
																								if (num27 != 4626604192193052672L)
																								{
																									if (num27 != 4626885667169763328L)
																									{
																										if (num27 != 4627167142146473984L)
																										{
																											goto IL_0800;
																										}
																										result = 1E+23 + x;
																									}
																									else
																									{
																										result = 1E+22;
																									}
																								}
																								else
																								{
																									result = 1E+21;
																								}
																							}
																							else
																							{
																								result = 1E+20;
																							}
																						}
																						else
																						{
																							result = 1E+19;
																						}
																					}
																					else
																					{
																						result = 1E+18;
																					}
																				}
																				else
																				{
																					result = 1E+17;
																				}
																			}
																			else
																			{
																				result = 10000000000000000.0;
																			}
																		}
																		else
																		{
																			result = 1000000000000000.0;
																		}
																	}
																	else
																	{
																		result = 100000000000000.0;
																	}
																}
																else
																{
																	result = 10000000000000.0;
																}
															}
															else
															{
																result = 1000000000000.0;
															}
														}
														else
														{
															result = 100000000000.0;
														}
													}
													else
													{
														result = 10000000000.0;
													}
												}
												else
												{
													result = 1000000000.0;
												}
											}
											else
											{
												result = 100000000.0;
											}
										}
										else
										{
											result = 10000000.0;
										}
									}
									else
									{
										result = 1000000.0;
									}
								}
								else
								{
									result = 100000.0;
								}
							}
							else
							{
								result = 10000.0;
							}
						}
						else
						{
							result = 1000.0;
						}
					}
					else
					{
						result = 100.0;
					}
				}
				else
				{
					result = 10.0;
				}
			}
			goto IL_0a1d;
		}
		IL_0b1f:
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_0a1d:
		llvm_lifetime_end_p0.Invoke(8L, &num11);
		llvm_lifetime_end_p0.Invoke(8L, &num10);
		llvm_lifetime_end_p0.Invoke(8L, &num9);
		llvm_lifetime_end_p0.Invoke(8L, &x2);
		llvm_lifetime_end_p0.Invoke(8L, &y);
		llvm_lifetime_end_p0.Invoke(8L, &num8);
		llvm_lifetime_end_p0.Invoke(8L, &z);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		llvm_lifetime_end_p0.Invoke(4L, &num7);
		llvm_lifetime_end_p0.Invoke(4L, &num6);
		llvm_lifetime_end_p0.Invoke(4L, &num5);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		goto IL_0b1f;
		IL_0800:
		llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
		unchecked
		{
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = anonymous_namespace_exp10_double_double_double_double_NumberPair_double_const.Invoke(x, num4, &numberPair3);
			NumberPair* num28 = &numberPair4;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num28 = struct_4ydhja5.field_0;
			byte* num29 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num29 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = numberPair4.hi + (numberPair4.lo + 2.3665827156630354E-30);
			llvm_lifetime_start_p0.Invoke(8L, &num16);
			num16 = numberPair4.hi + (numberPair4.lo - 2.3665827156630354E-30);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num15 == num16, expected: true))
			{
				llvm_lifetime_start_p0.Invoke(8L, &num17);
				num17 = (long)num7 << 52;
				llvm_lifetime_start_p0.Invoke(8L, &num18);
				llvm_lifetime_start_p0.Invoke(8L, &num19);
				num19 = checked(num17 + cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&num15));
				double num30 = cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const.Invoke(&num19);
				llvm_lifetime_end_p0.Invoke(8L, &num19);
				num18 = num30;
				result = num18;
				llvm_lifetime_end_p0.Invoke(8L, &num18);
				llvm_lifetime_end_p0.Invoke(8L, &num17);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
				*(long*)ptr2 = -6148914691236517206L;
				((long*)ptr2)[1] = -6148914691236517206L;
				anonymous_namespace_exp10_f128_double_double_int_int.Invoke(&fputil_DyadicFloat_kt2kd5, x, num4, num5, num6);
				result = fputil_DyadicFloat_128ul_operator_double_double_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num16);
			llvm_lifetime_end_p0.Invoke(8L, &num15);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			goto IL_0a1d;
		}
	}
}
