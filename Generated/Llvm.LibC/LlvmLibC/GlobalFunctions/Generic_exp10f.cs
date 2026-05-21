using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_exp10f
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic6exp10fEf")]
	[DemangledName("__llvm_libc_20_1_2_::generic::exp10f(float)")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num3 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num4 = 0.0;
		double num5 = 0.0;
		double z = 0.0;
		double y = 0.0;
		double x = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (!Details_expects_bool_condition_bool.Invoke((uint)num2 >= 1109008539u, Expected: false))
			{
				goto IL_0337;
			}
			if ((uint)num > 3258228277u)
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					result = 0f;
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					result = X;
				}
				else if (Fputil_fenv_is_round_up.Invoke())
				{
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal.Invoke(anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				}
				else
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(16);
					result = 0f;
				}
			}
			else
			{
				if (!FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) || (uint)num < 1109008539u)
				{
					goto IL_0337;
				}
				if ((uint)num < 2139095040u)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = Fputil_quick_get_round.Invoke();
					int num6;
					if (num3 == 1024 || num3 == 3072)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb2.Val);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
						result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
						num6 = 1;
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						num6 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
					switch (num6)
					{
					case 0:
						break;
					default:
						goto IL_06c5;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb3.Val);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
				result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			}
			goto IL_06c5;
		}
		IL_04f0:
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Llvm_libc_20_1_2_exp_b_range_reduc_Exp10Base.Invoke(X);
			Llvm_libc_20_1_2_NumberPair* num7 = &llvm_libc_20_1_2_NumberPair;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num7 = struct_4ydhja2.field_0;
			byte* num8 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num8 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = llvm_libc_20_1_2_NumberPair.Hi * llvm_libc_20_1_2_NumberPair.Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair.Hi, *(double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer, 1.0);
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair.Hi, ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[2L], ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[1]);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair.Hi, ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[4L], ((double*)Llvm_libc_20_1_2_Exp10Base_COEFFS.Pointer)[3L]);
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = Fputil_multiply_add_double.Invoke(num4, y, z);
			result = (float)Fputil_multiply_add_double.Invoke(x, num4 * llvm_libc_20_1_2_NumberPair.Lo, num5 * llvm_libc_20_1_2_NumberPair.Lo);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			goto IL_06c5;
		}
		IL_0337:
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke((uint)num2 <= 999956635u, Expected: false))
			{
				result = ((Details_expects_bool_condition_bool.Invoke(num == -1302438951, Expected: false) && Fputil_fenv_is_round_to_nearest.Invoke()) ? ((float)Math.PI * 113f / 355f) : ((!Details_expects_bool_condition_bool.Invoke((uint)num2 <= 847249408u, Expected: false)) ? ((float)Exp10Base_powb_lo.Invoke(X)) : Fputil_multiply_add_float.Invoke(X, 2.3025851f, 1f)));
			}
			else if (Details_expects_bool_condition_bool.Invoke(num == 1024776534, Expected: false) && Fputil_fenv_is_round_up.Invoke())
			{
				result = 1.0872767f;
			}
			else
			{
				if (!Details_expects_bool_condition_bool.Invoke((num & -2146435073) == 0, Expected: false))
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
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
	}
}
