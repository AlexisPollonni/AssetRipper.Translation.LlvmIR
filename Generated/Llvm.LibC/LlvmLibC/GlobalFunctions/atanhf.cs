using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class atanhf
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		double num2 = 0.0;
		double x2 = 0.0;
		double y = 0.0;
		double num3 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			num = num4;
			float result;
			if (details_expects_bool_condition_bool.Invoke((uint)num >= 1065353216u, expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = x;
				}
				else if (num == 1065353216)
				{
					fputil_set_errno_if_required.Invoke(34);
					fputil_raise_except_if_required.Invoke(4);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb9.val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
				else
				{
					fputil_set_errno_if_required.Invoke(33);
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb10.val, 0);
					fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				}
			}
			else if (details_expects_bool_condition_bool.Invoke((uint)num <= 1036779520u, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((uint)num <= 847249408u, expected: false))
				{
					result = (float)((!details_expects_bool_condition_bool.Invoke(num == 0, expected: false)) ? llvm_fmuladd_f64.Invoke(1.0 / 3.0 * (double)x * (double)x, x, x) : ((double)x));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = x;
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num2 * num2;
					llvm_lifetime_start_p0.Invoke(8L, &y);
					y = fputil_polyeval_double_double_double_double_double_double.Invoke(x2, 0.0, 1.0 / 3.0, 0.2, 1.0 / 7.0, 1.0 / 9.0, 1.0 / 11.0);
					result = (float)fputil_multiply_add_double.Invoke(num2, y, num2);
					llvm_lifetime_end_p0.Invoke(8L, &y);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
					llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = x;
				result = (float)(0.5 * log_eval_c36zya.Invoke((num3 + 1.0) / (num3 - 1.0)));
				llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
