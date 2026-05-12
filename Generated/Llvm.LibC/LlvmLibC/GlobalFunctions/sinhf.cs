using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sinhf
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		double num2 = 0.0;
		double x2 = 0.0;
		double y = 0.0;
		int num3 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		float result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			int field_ = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num4 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			num = num4;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((uint)num < 1119092736u) ? ((uint)num <= 1033895936u) : true, expected: false))
			{
				if ((uint)num <= 1033895936u)
				{
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 974292479, expected: false) && fputil_fenv_is_round_to_nearest.Invoke())
					{
						result = x;
					}
					else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num <= 847249408u, expected: false))
					{
						result = (float)((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 0, expected: false)) ? llvm_fmuladd_f64.Invoke(0.25 * (double)x * (double)x, x, x) : ((double)x));
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num2);
						num2 = x;
						llvm_lifetime_start_p0.Invoke(8L, &x2);
						x2 = num2 * num2;
						llvm_lifetime_start_p0.Invoke(8L, &y);
						y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double.Invoke(x2, 0.0, 0.16666666666678162, 0.00833333321902746, 0.00019844500753408458);
						result = (float)fputil_multiply_add_double_double_double.Invoke(num2, y, num2);
						llvm_lifetime_end_p0.Invoke(8L, &y);
						llvm_lifetime_end_p0.Invoke(8L, &x2);
						llvm_lifetime_end_p0.Invoke(8L, &num2);
					}
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = x + 1f;
				}
				else
				{
					if (!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = fputil_quick_get_round.Invoke();
						if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
						{
							if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((num3 != 2048) ? (num3 == 3072) : true, expected: false))
							{
								goto IL_03bd;
							}
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal_Sign.Invoke(anon_izyfb8.val);
							fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
							result = 0f - fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						}
						else
						{
							if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((num3 != 1024) ? (num3 == 3072) : true, expected: false))
							{
								goto IL_03bd;
							}
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal_Sign.Invoke(anon_izyfb9.val);
							fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
							result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						}
						goto IL_0430;
					}
					result = x;
				}
			}
			else
			{
				result = (float)double_exp_pm_eval_true_float.Invoke(x);
			}
			goto IL_044d;
		}
		IL_0430:
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_044d;
		IL_044d:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
		IL_03bd:
		fputil_set_errno_if_required_int.Invoke(34);
		fputil_raise_except_if_required_int.Invoke(8);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
		anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
		int field_4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb10.val);
		fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
		result = x + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
		goto IL_0430;
	}
}
