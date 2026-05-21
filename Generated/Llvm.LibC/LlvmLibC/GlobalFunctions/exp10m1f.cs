using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exp10m1f
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		cpp_optional_xmxtsi cpp_optional_xmxtsi2 = default(cpp_optional_xmxtsi);
		double num4 = 0.0;
		double x2 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		cpp_optional_xmxtsi cpp_optional_xmxtsi3 = default(cpp_optional_xmxtsi);
		NumberPair numberPair = default(NumberPair);
		double x3 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double a_ijazrn2 = 0.0;
		double x4 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) && (uint)num >= 1109008539u, expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_finite.Invoke(&fputil_FPBits_5nkvcs2))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = fputil_quick_get_round.Invoke();
					int num9;
					if (num3 == 1024 || num3 == 3072)
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb8.val);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						num9 = 1;
					}
					else
					{
						fputil_set_errno_if_required.Invoke(34);
						fputil_raise_except_if_required.Invoke(8);
						num9 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					switch (num9)
					{
					case 0:
						break;
					default:
						goto IL_09a7;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb9.val);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				result = x + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			}
			else if (details_expects_bool_condition_bool.Invoke((uint)num2 <= 999956635u, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi2);
				sbyte* ptr = (sbyte*)(&cpp_optional_xmxtsi2);
				*(float*)ptr = float.NaN;
				ptr[4] = -86;
				sbyte* ptr2 = ptr + 5;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				long storage = ExceptValues_float_11ul_lookup.Invoke(x_bits: num, @this: EXP10M1F_EXCEPTS_LO.Pointer);
				*(long*)(&cpp_optional_xmxtsi2.storage) = storage;
				int num9;
				if (details_expects_bool_condition_bool.Invoke(optional_float_has_value.Invoke(&cpp_optional_xmxtsi2), expected: false))
				{
					result = *(float*)optional_float_value.Invoke(&cpp_optional_xmxtsi2);
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi2);
				switch (num9)
				{
				case 0:
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = x;
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num4 * num4;
					llvm_lifetime_start_p0.Invoke(8L, &a);
					a = num4 * *(double*)Exp10Base_COEFFS.Pointer;
					llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
					a_yc74sk = fputil_multiply_add_double.Invoke(num4, ((double*)Exp10Base_COEFFS.Pointer)[2L], ((double*)Exp10Base_COEFFS.Pointer)[1]);
					llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
					a_ijazrn = fputil_multiply_add_double.Invoke(num4, ((double*)Exp10Base_COEFFS.Pointer)[4L], ((double*)Exp10Base_COEFFS.Pointer)[3L]);
					result = (float)fputil_polyeval_double_double_double.Invoke(x2, a, a_yc74sk, a_ijazrn);
					llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
					llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
					llvm_lifetime_end_p0.Invoke(8L, &a);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					break;
				}
			}
			else if (details_expects_bool_condition_bool.Invoke((uint)num >= 3237008113u, expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = -1f;
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = x;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = fputil_quick_get_round.Invoke();
					if (num5 == 2048 || num5 == 3072 || (num5 == 0 && num == -1057959183))
					{
						result = (float)Math.PI * -113f / 355f;
					}
					else
					{
						fputil_set_errno_if_required.Invoke(34);
						fputil_raise_except_if_required.Invoke(16);
						result = -1f;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num5);
				}
			}
			else
			{
				if (!details_expects_bool_condition_bool.Invoke((num & -2146435073) == 0, expected: false))
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
													llvm_lifetime_start_p0.Invoke(4L, &num8);
													num8 = fputil_quick_get_round.Invoke();
													result = ((num8 != 2048 && num8 != 0) ? 9.999999E+09f : 1E+10f);
													llvm_lifetime_end_p0.Invoke(4L, &num8);
												}
												else
												{
													llvm_lifetime_start_p0.Invoke(4L, &num7);
													num7 = fputil_quick_get_round.Invoke();
													result = ((num7 != 2048 && num7 != 0) ? 999999940f : 1E+09f);
													llvm_lifetime_end_p0.Invoke(4L, &num7);
												}
											}
											else
											{
												llvm_lifetime_start_p0.Invoke(4L, &num6);
												num6 = fputil_quick_get_round.Invoke();
												result = ((num6 != 2048 && num6 != 0) ? 99999990f : 100000000f);
												llvm_lifetime_end_p0.Invoke(4L, &num6);
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
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
		IL_0734:
		llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi3);
		unchecked
		{
			sbyte* ptr3 = (sbyte*)(&cpp_optional_xmxtsi3);
			*(float*)ptr3 = float.NaN;
			ptr3[4] = -86;
			sbyte* ptr4 = ptr3 + 5;
			*ptr4 = -86;
			ptr4[1] = -86;
			ptr4[2] = -86;
			long storage2 = ExceptValues_float_19ul_lookup.Invoke(x_bits: num, @this: EXP10M1F_EXCEPTS_HI.Pointer);
			*(long*)(&cpp_optional_xmxtsi3.storage) = storage2;
			int num9;
			if (details_expects_bool_condition_bool.Invoke(optional_float_has_value.Invoke(&cpp_optional_xmxtsi3), expected: false))
			{
				result = *(float*)optional_float_value.Invoke(&cpp_optional_xmxtsi3);
				num9 = 1;
			}
			else
			{
				num9 = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi3);
			switch (num9)
			{
			case 0:
			{
				llvm_lifetime_start_p0.Invoke(16L, &numberPair);
				*(double*)(&numberPair) = double.NaN;
				((double*)(&numberPair))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja = exp_b_range_reduc_Exp10Base.Invoke(x);
				NumberPair* num11 = &numberPair;
				Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
				*(double*)num11 = struct_4ydhja2.field_0;
				byte* num12 = (byte*)(&numberPair) + 8u;
				Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
				*(double*)num12 = struct_4ydhja3.field_1;
				llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = numberPair.hi * numberPair.hi;
				llvm_lifetime_start_p0.Invoke(8L, &a2);
				a2 = fputil_multiply_add_double.Invoke(numberPair.hi, *(double*)Exp10Base_COEFFS.Pointer, 1.0);
				llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
				a_yc74sk2 = fputil_multiply_add_double.Invoke(numberPair.hi, ((double*)Exp10Base_COEFFS.Pointer)[2L], ((double*)Exp10Base_COEFFS.Pointer)[1]);
				llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn2);
				a_ijazrn2 = fputil_multiply_add_double.Invoke(numberPair.hi, ((double*)Exp10Base_COEFFS.Pointer)[4L], ((double*)Exp10Base_COEFFS.Pointer)[3L]);
				llvm_lifetime_start_p0.Invoke(8L, &x4);
				x4 = fputil_polyeval_double_double_double.Invoke(x3, a2, a_yc74sk2, a_ijazrn2);
				result = (float)fputil_multiply_add_double.Invoke(x4, numberPair.lo, -1.0);
				llvm_lifetime_end_p0.Invoke(8L, &x4);
				llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn2);
				llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
				llvm_lifetime_end_p0.Invoke(8L, &a2);
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair);
				break;
			}
			}
			goto IL_09a7;
		}
	}
}
