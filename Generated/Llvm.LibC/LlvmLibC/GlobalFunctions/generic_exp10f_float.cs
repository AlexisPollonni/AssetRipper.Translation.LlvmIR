using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic6exp10fEf")]
[DemangledName("__llvm_libc_20_1_2_::generic::exp10f(float)")]
internal static partial class generic_exp10f_float
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num3 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		NumberPair numberPair = default(NumberPair);
		double num4 = 0.0;
		double num5 = 0.0;
		double z = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num2 >= 1109008539u, expected: false))
			{
				goto IL_0337;
			}
			if ((uint)num > 3258228277u)
			{
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = 0f;
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = x;
				}
				else if (fputil_fenv_is_round_up.Invoke())
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal_Sign.Invoke(anon_izyfb8.val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
				else
				{
					fputil_set_errno_if_required_int.Invoke(34);
					fputil_raise_except_if_required_int.Invoke(16);
					result = 0f;
				}
			}
			else
			{
				if (!fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos_const.Invoke(&fputil_FPBits_5nkvcs2) || (uint)num < 1109008539u)
				{
					goto IL_0337;
				}
				if ((uint)num < 2139095040u)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = fputil_quick_get_round.Invoke();
					int num6;
					if (num3 == 1024 || num3 == 3072)
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal_Sign.Invoke(anon_izyfb9.val);
						fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
						result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						num6 = 1;
					}
					else
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(8);
						num6 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					switch (num6)
					{
					case 0:
						break;
					default:
						goto IL_06c5;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb10.val);
				fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
				result = x + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			}
			goto IL_06c5;
		}
		IL_04f0:
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = exp_b_reduc_t_exp_b_range_reduc_Exp10Base_float.Invoke(x);
			NumberPair* num7 = &numberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num7 = struct_4ydhja2.field_0;
			byte* num8 = (byte*)(&numberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num8 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = numberPair.hi * numberPair.hi;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = fputil_multiply_add_double_double_double.Invoke(numberPair.hi, *(double*)Exp10Base_COEFFS.Pointer, 1.0);
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double_double_double.Invoke(numberPair.hi, ((double*)Exp10Base_COEFFS.Pointer)[2L], ((double*)Exp10Base_COEFFS.Pointer)[1]);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = fputil_multiply_add_double_double_double.Invoke(numberPair.hi, ((double*)Exp10Base_COEFFS.Pointer)[4L], ((double*)Exp10Base_COEFFS.Pointer)[3L]);
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = fputil_multiply_add_double_double_double.Invoke(num4, y, z);
			result = (float)fputil_multiply_add_double_double_double.Invoke(x2, num4 * numberPair.lo, num5 * numberPair.lo);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			goto IL_06c5;
		}
		IL_0337:
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num2 <= 999956635u, expected: false))
			{
				result = ((bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == -1302438951, expected: false) && fputil_fenv_is_round_to_nearest.Invoke()) ? ((float)Math.PI * 113f / 355f) : ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num2 <= 847249408u, expected: false)) ? ((float)Exp10Base_powb_lo_double.Invoke(x)) : fputil_multiply_add_float_float_float.Invoke(x, 2.3025851f, 1f)));
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 1024776534, expected: false) && fputil_fenv_is_round_up.Invoke())
			{
				result = 1.0872767f;
			}
			else
			{
				if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((num & -2146435073) == 0, expected: false))
				{
					goto IL_04f0;
				}
				int num9 = num;
				if (num9 != 1065353216)
				{
					if (num9 != 1073741824)
					{
						if (num9 != 1077936128)
						{
							if (num9 != 1082130432)
							{
								if (num9 != 1084227584)
								{
									if (num9 != 1086324736)
									{
										if (num9 != 1088421888)
										{
											if (num9 != 1090519040)
											{
												if (num9 != 1091567616)
												{
													if (num9 != 1092616192)
													{
														goto IL_04f0;
													}
													result = 1E+10f;
												}
												else
												{
													result = 1E+09f;
												}
											}
											else
											{
												result = 100000000f;
											}
										}
										else
										{
											result = 10000000f;
										}
									}
									else
									{
										result = 1000000f;
									}
								}
								else
								{
									result = 100000f;
								}
							}
							else
							{
								result = 10000f;
							}
						}
						else
						{
							result = 1000f;
						}
					}
					else
					{
						result = 100f;
					}
				}
				else
				{
					result = 10f;
				}
			}
			goto IL_06c5;
		}
		IL_06c5:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}
