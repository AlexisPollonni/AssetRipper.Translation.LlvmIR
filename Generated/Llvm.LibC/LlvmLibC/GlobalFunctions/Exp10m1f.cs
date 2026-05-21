using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp10m1f
{
	[MangledName("exp10m1f")]
	[DemangledName("exp10m1f")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_cpp_optional_xmxtsi llvm_libc_20_1_2_cpp_optional_xmxtsi = default(Llvm_libc_20_1_2_cpp_optional_xmxtsi);
		double num4 = 0.0;
		double x = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		Llvm_libc_20_1_2_cpp_optional_xmxtsi llvm_libc_20_1_2_cpp_optional_xmxtsi2 = default(Llvm_libc_20_1_2_cpp_optional_xmxtsi);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double x2 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double a_ijazrn2 = 0.0;
		double x3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) && (uint)num >= 1109008539u, Expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_finite.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = Fputil_quick_get_round.Invoke();
					int num9;
					if (num3 == 1024 || num3 == 3072)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb.Val);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						num9 = 1;
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						num9 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
					switch (num9)
					{
					case 0:
						break;
					default:
						goto IL_09a7;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num2 <= 999956635u, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
				*(float*)ptr = float.NaN;
				ptr[4] = -86;
				sbyte* ptr2 = ptr + 5;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				long storage = ExceptValues_float_11ul_lookup.Invoke(X_bits: num, This: Llvm_libc_20_1_2_EXP10M1F_EXCEPTS_LO.Pointer);
				*(long*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi.Storage) = storage;
				int num9;
				if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi), Expected: false))
				{
					result = *(float*)Optional_float_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi);
				switch (num9)
				{
				case 0:
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = X;
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = num4 * num4;
					Llvm_lifetime_start_p0.Invoke(8L, &a);
					a = num4 * *(double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer;
					Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
					a_yc74sk = Fputil_multiply_add_double.Invoke(num4, ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[2L], ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[1]);
					Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
					a_ijazrn = Fputil_multiply_add_double.Invoke(num4, ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[4L], ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[3L]);
					result = (float)Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
					Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
					Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
					Llvm_lifetime_end_p0.Invoke(8L, &a);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
					break;
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num >= 3237008113u, Expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					result = -1f;
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					result = X;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = Fputil_quick_get_round.Invoke();
					if (num5 == 2048 || num5 == 3072 || (num5 == 0 && num == -1057959183))
					{
						result = (float)Math.PI * -113f / 355f;
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
						result = -1f;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
				}
			}
			else
			{
				if (!Details_expects_bool_condition_bool.Invoke((num & -2146435073) == 0, Expected: false))
				{
					goto IL_0734;
				}
				int num10 = num;
				if (num10 != 1065353216)
				{
					if (num10 != 1073741824)
					{
						if (num10 != 1077936128)
						{
							if (num10 != 1082130432)
							{
								if (num10 != 1084227584)
								{
									if (num10 != 1086324736)
									{
										if (num10 != 1088421888)
										{
											if (num10 != 1090519040)
											{
												if (num10 != 1091567616)
												{
													if (num10 != 1092616192)
													{
														goto IL_0734;
													}
													Llvm_lifetime_start_p0.Invoke(4L, &num8);
													num8 = Fputil_quick_get_round.Invoke();
													result = ((num8 != 2048 && num8 != 0) ? 9.999999E+09f : 1E+10f);
													Llvm_lifetime_end_p0.Invoke(4L, &num8);
												}
												else
												{
													Llvm_lifetime_start_p0.Invoke(4L, &num7);
													num7 = Fputil_quick_get_round.Invoke();
													result = ((num7 != 2048 && num7 != 0) ? 999999940f : 1E+09f);
													Llvm_lifetime_end_p0.Invoke(4L, &num7);
												}
											}
											else
											{
												Llvm_lifetime_start_p0.Invoke(4L, &num6);
												num6 = Fputil_quick_get_round.Invoke();
												result = ((num6 != 2048 && num6 != 0) ? 99999990f : 100000000f);
												Llvm_lifetime_end_p0.Invoke(4L, &num6);
											}
										}
										else
										{
											result = 9999999f;
										}
									}
									else
									{
										result = 999999f;
									}
								}
								else
								{
									result = 99999f;
								}
							}
							else
							{
								result = 9999f;
							}
						}
						else
						{
							result = 999f;
						}
					}
					else
					{
						result = 99f;
					}
				}
				else
				{
					result = 9f;
				}
			}
			goto IL_09a7;
		}
		IL_09a7:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
		IL_0734:
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi2);
		unchecked
		{
			sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi2);
			*(float*)ptr3 = float.NaN;
			ptr3[4] = -86;
			sbyte* ptr4 = ptr3 + 5;
			*ptr4 = -86;
			ptr4[1] = -86;
			ptr4[2] = -86;
			long storage2 = ExceptValues_float_19ul_lookup.Invoke(X_bits: num, This: Llvm_libc_20_1_2_EXP10M1F_EXCEPTS_HI.Pointer);
			*(long*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi2.Storage) = storage2;
			int num9;
			if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi2), Expected: false))
			{
				result = *(float*)Optional_float_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi2);
				num9 = 1;
			}
			else
			{
				num9 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi2);
			switch (num9)
			{
			case 0:
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
				*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja = Llvm_libc_20_1_2_exp_b_range_reduc_Exp10Base.Invoke(X);
				Llvm_libc_20_1_2_NumberPair* num11 = &llvm_libc_20_1_2_NumberPair;
				Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
				*(double*)num11 = struct_4ydhja2.field_0;
				byte* num12 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
				Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
				*(double*)num12 = struct_4ydhja3.field_1;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = llvm_libc_20_1_2_NumberPair.Hi * llvm_libc_20_1_2_NumberPair.Hi;
				Llvm_lifetime_start_p0.Invoke(8L, &a2);
				a2 = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair.Hi, *(double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer, 1.0);
				Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
				a_yc74sk2 = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair.Hi, ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[2L], ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[1]);
				Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn2);
				a_ijazrn2 = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair.Hi, ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[4L], ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[3L]);
				Llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = Fputil_polyeval_double_double_double.Invoke(x2, a2, a_yc74sk2, a_ijazrn2);
				result = (float)Fputil_multiply_add_double.Invoke(x3, llvm_libc_20_1_2_NumberPair.Lo, -1.0);
				Llvm_lifetime_end_p0.Invoke(8L, &x3);
				Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn2);
				Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
				Llvm_lifetime_end_p0.Invoke(8L, &a2);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
				break;
			}
			}
			goto IL_09a7;
		}
	}
}
