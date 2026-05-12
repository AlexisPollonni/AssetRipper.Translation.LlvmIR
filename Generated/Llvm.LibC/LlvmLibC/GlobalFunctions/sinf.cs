using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sinf
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		double x2 = 0.0;
		double num4 = 0.0;
		float num5 = 0f;
		int num6 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		double num7 = 0.0;
		double y = 0.0;
		double x3 = 0.0;
		double x4 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = x;
			float result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num2 <= 1044975579u, expected: false))
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num2 < 971544425u, expected: false))
				{
					result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 == 0, expected: false)) ? fputil_multiply_add_float_float_float.Invoke(x, -2.9802322E-08f, x) : x);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num3 * num3;
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double_double_double.Invoke(x2, 1.0, -0.1666666666666627, 0.008333333332344492, -0.00019841262154916348, 2.7533705626961157E-06);
					result = (float)(num3 * num4);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
				}
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 == 1176082840, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = -0.34761325f;
				llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = fputil_quick_get_round.Invoke();
				if ((num6 == 1024 && fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2))) || (num6 == 2048 && fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2))))
				{
					num5 = -0.34761328f;
				}
				result = ((!fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2))) ? num5 : (0f - num5));
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num2 >= 2139095040u, expected: false))
			{
				if (num2 == 2139095040)
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb8.val, 0);
				fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = x + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &y);
				y = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &x4);
				x4 = double.NaN;
				sincosf_eval_double_unsigned_int_double_double_double_double.Invoke(num3, num2, &num7, &y, &x3, &x4);
				result = (float)fputil_multiply_add_double_double_double.Invoke(x3, y, fputil_multiply_add_double_double_double.Invoke(x4, num7, num7));
				llvm_lifetime_end_p0.Invoke(8L, &x4);
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(8L, &y);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
