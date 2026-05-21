using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sinpif
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		double num4 = 0.0;
		double x2 = 0.0;
		double num5 = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num6 = 0.0;
		double y = 0.0;
		double num7 = 0.0;
		double x3 = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = x;
			float result;
			if (details_expects_bool_condition_bool.Invoke((uint)num2 <= 1031798784u, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((uint)num2 < 869073367u, expected: false))
				{
					if (details_expects_bool_condition_bool.Invoke(num2 == 0, expected: false))
					{
						result = x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = num3 * Math.PI;
						result = (float)num4;
						llvm_lifetime_end_p0.Invoke(8L, &num4);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num3 * num3;
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = fputil_polyeval_double_double_double_double_double.Invoke(x2, Math.PI, -5.167712780049429, 2.55016403919051, -0.5992641661056299, 0.0820605914557699);
					result = (float)(num3 * num5);
					llvm_lifetime_end_p0.Invoke(8L, &num5);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
				}
			}
			else if (details_expects_bool_condition_bool.Invoke((uint)num2 >= 1258291200u, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((uint)num2 >= 2139095040u, expected: false))
				{
					if (num2 == 2139095040)
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
					}
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = x + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					anon_izyfb9.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb9.val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &y);
				y = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = double.NaN;
				sincospif_eval.Invoke(num3, &num6, &y, &num7, &x3);
				if (details_expects_bool_condition_bool.Invoke(num7 == 0.0 && num6 == 0.0, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					anon_izyfb10.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb10.val);
					fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				}
				else
				{
					result = (float)fputil_multiply_add_double.Invoke(num7, y, fputil_multiply_add_double.Invoke(x3, num6, num6));
				}
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &y);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
