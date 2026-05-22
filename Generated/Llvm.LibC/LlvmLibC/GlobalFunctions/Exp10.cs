using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp10
{
	[MangledName("exp10")]
	[DemangledName("exp10")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num = 0L;
		double num2 = 0.0;
		int num3 = 0;
		double num4 = 0.0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		double z = 0.0;
		double num8 = 0.0;
		double y = 0.0;
		double x = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		double num11 = 0.0;
		long num12 = 0L;
		double num13 = 0.0;
		long num14 = 0L;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		double num15 = 0.0;
		double num16 = 0.0;
		long num17 = 0L;
		double num18 = 0.0;
		long num19 = 0L;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double result;
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			if (Details_expects_bool_condition_bool.Invoke((ulong)num >= 13867491935800207938uL || ((ulong)num <= 13581672830762149134uL && (ulong)num >= 4644130490496809471uL) || (ulong)num < 4362804393534743822uL, Expected: false))
			{
				result = Anonymous_namespace_set_exceptional_a9yqfd.Invoke(X);
				goto IL_0b1f;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = Fputil_multiply_add_double.Invoke(X, 3.321928094887362, 3145728.0001220703);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)(Cpp_bit_cast_unsigned_long_double.Invoke(&num2) >>> 19);
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = num3;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = (num3 >> 6) & 0x3F;
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = num3 & 0x3F;
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = num3 >> 12;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			long num20 = (uint)num5;
			llvm_libc_20_1_2_NumberPair.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num20].Mid;
			long num21 = (uint)num5;
			llvm_libc_20_1_2_NumberPair.Hi = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num21].Hi;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			long num22 = (uint)num6;
			llvm_libc_20_1_2_NumberPair2.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID2.Pointer)[num22].Mid;
			long num23 = (uint)num6;
			llvm_libc_20_1_2_NumberPair2.Hi = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID2.Pointer)[num23].Hi;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num24 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num24 = struct_4ydhja2.field_0;
			byte* num25 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num25 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(num4, -7.349365128561658E-05, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = Fputil_multiply_add_double.Invoke(num4, 4.649201285928778E-16, z);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = num8 * llvm_libc_20_1_2_NumberPair3.Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = Anonymous_namespace_poly_approx_d_twxp8v.Invoke(num8);
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = Fputil_multiply_add_double.Invoke(x, y, llvm_libc_20_1_2_NumberPair3.Lo);
			Llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = llvm_libc_20_1_2_NumberPair3.Hi + (num9 + 1.6263032587282567E-19);
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = llvm_libc_20_1_2_NumberPair3.Hi + (num9 - 1.6263032587282567E-19);
			if (Details_expects_bool_condition_bool.Invoke(num10 == num11, Expected: true))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num12);
				num12 = (long)num7 << 52;
				Llvm_lifetime_start_p0.Invoke(8L, &num13);
				Llvm_lifetime_start_p0.Invoke(8L, &num14);
				num14 = checked(num12 + Cpp_bit_cast_long_double.Invoke(&num10));
				double num26 = Cpp_bit_cast_double_long.Invoke(&num14);
				Llvm_lifetime_end_p0.Invoke(8L, &num14);
				num13 = num26;
				result = num13;
				Llvm_lifetime_end_p0.Invoke(8L, &num13);
				Llvm_lifetime_end_p0.Invoke(8L, &num12);
			}
			else
			{
				if (!Details_expects_bool_condition_bool.Invoke((num & -9223090561878065153L) == 0L, Expected: false))
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
																										result = 1E+23 + X;
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
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		return result;
		IL_0a1d:
		Llvm_lifetime_end_p0.Invoke(8L, &num11);
		Llvm_lifetime_end_p0.Invoke(8L, &num10);
		Llvm_lifetime_end_p0.Invoke(8L, &num9);
		Llvm_lifetime_end_p0.Invoke(8L, &x);
		Llvm_lifetime_end_p0.Invoke(8L, &y);
		Llvm_lifetime_end_p0.Invoke(8L, &num8);
		Llvm_lifetime_end_p0.Invoke(8L, &z);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_end_p0.Invoke(4L, &num7);
		Llvm_lifetime_end_p0.Invoke(4L, &num6);
		Llvm_lifetime_end_p0.Invoke(4L, &num5);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		goto IL_0b1f;
		IL_0800:
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_exp10_double_double.Invoke(X, num4, &llvm_libc_20_1_2_NumberPair3);
			Llvm_libc_20_1_2_NumberPair* num28 = &llvm_libc_20_1_2_NumberPair4;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num28 = struct_4ydhja5.field_0;
			byte* num29 = (byte*)(&llvm_libc_20_1_2_NumberPair4) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num29 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = llvm_libc_20_1_2_NumberPair4.Hi + (llvm_libc_20_1_2_NumberPair4.Lo + 2.3665827156630354E-30);
			Llvm_lifetime_start_p0.Invoke(8L, &num16);
			num16 = llvm_libc_20_1_2_NumberPair4.Hi + (llvm_libc_20_1_2_NumberPair4.Lo - 2.3665827156630354E-30);
			if (Details_expects_bool_condition_bool.Invoke(num15 == num16, Expected: true))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num17);
				num17 = (long)num7 << 52;
				Llvm_lifetime_start_p0.Invoke(8L, &num18);
				Llvm_lifetime_start_p0.Invoke(8L, &num19);
				num19 = checked(num17 + Cpp_bit_cast_long_double.Invoke(&num15));
				double num30 = Cpp_bit_cast_double_long.Invoke(&num19);
				Llvm_lifetime_end_p0.Invoke(8L, &num19);
				num18 = num30;
				result = num18;
				Llvm_lifetime_end_p0.Invoke(8L, &num18);
				Llvm_lifetime_end_p0.Invoke(8L, &num17);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
				*(long*)ptr2 = -6148914691236517206L;
				((long*)ptr2)[1] = -6148914691236517206L;
				Anonymous_namespace_exp10_f128.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, X, num4, num5, num6);
				result = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num16);
			Llvm_lifetime_end_p0.Invoke(8L, &num15);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			goto IL_0a1d;
		}
	}
}
