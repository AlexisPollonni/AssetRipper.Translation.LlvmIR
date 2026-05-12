using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class acoshf
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		double num2 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(!(x > 1f), expected: false))
			{
				if (x == 1f)
				{
					result = 0f;
				}
				else
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
			}
			else
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num >= 1334835971u, expected: false))
				{
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), expected: false))
					{
						result = x;
						goto IL_02a7;
					}
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
					*(sbyte*)(&anon_izyfb9) = -86;
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb10);
					*(sbyte*)(&anon_izyfb10) = -86;
					int num3;
					switch (num)
					{
					case 1334835971:
						result = acoshf_impl_float_1_operator_float_const.Invoke(&anon_izyfb10, 22.991505f);
						num3 = 1;
						break;
					case 1549180552:
						result = acoshf_impl_float_1_operator_float_const.Invoke(&anon_izyfb10, 40.71937f);
						num3 = 1;
						break;
					case 1583913038:
						result = acoshf_impl_float_1_operator_float_const.Invoke(&anon_izyfb10, 43.57239f);
						num3 = 1;
						break;
					case 1700303059:
						result = acoshf_impl_float_0_operator_float_const.Invoke(&anon_izyfb9, 53.20505f);
						num3 = 1;
						break;
					case 1857136876:
						result = acoshf_impl_float_0_operator_float_const.Invoke(&anon_izyfb9, 66.17683f);
						num3 = 1;
						break;
					case 2040001290:
						result = acoshf_impl_float_1_operator_float_const.Invoke(&anon_izyfb10, 81.26974f);
						num3 = 1;
						break;
					default:
						num3 = 0;
						break;
					}
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb10);
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
					switch (num3)
					{
					case 0:
						break;
					default:
						goto IL_02a7;
					}
				}
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = x;
				result = (float)log_eval_double_64.Invoke(num2 + cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_double_sizeof_double_sizeof_double_double_type_fputil_sqrt_double_double_double.Invoke(fputil_multiply_add_double_double_double.Invoke(num2, num2, -1.0)));
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			goto IL_02a7;
		}
		IL_02a7:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}
