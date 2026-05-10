using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cosf
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		double xd = 0.0;
		cpp_optional_89h55j cpp_optional_89h55j2 = default(cpp_optional_89h55j);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num2 = 0.0;
		double num3 = 0.0;
		double x2 = 0.0;
		double x3 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb8.val);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(8L, &xd);
			xd = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num < 964689920u, expected: false))
			{
				result = fputil_multiply_add_float_float_float.Invoke(fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2), -2.9802322E-08f, 1f);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_89h55j2);
				sbyte* ptr = (sbyte*)(&cpp_optional_89h55j2);
				*(float*)ptr = float.NaN;
				ptr[4] = -86;
				sbyte* ptr2 = ptr + 5;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				long storage = fputil_ExceptValues_float_6ul_lookup_unsigned_int_const.Invoke(x_bits: num, @this: COSF_EXCEPTS.Pointer);
				*(long*)(&cpp_optional_89h55j2.storage) = storage;
				int num4;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_float_has_value_const.Invoke(&cpp_optional_89h55j2), expected: false))
				{
					result = *(float*)cpp_optional_float_value.Invoke(&cpp_optional_89h55j2);
					num4 = 1;
				}
				else
				{
					num4 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_89h55j2);
				switch (num4)
				{
				case 0:
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num >= 2139095040u, expected: false))
					{
						if (num == 2139095040)
						{
							fputil_set_errno_if_required_int.Invoke(33);
							fputil_raise_except_if_required_int.Invoke(1);
						}
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb9.val, 0);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = x + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num2);
						num2 = double.NaN;
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = double.NaN;
						llvm_lifetime_start_p0.Invoke(8L, &x2);
						x2 = double.NaN;
						llvm_lifetime_start_p0.Invoke(8L, &x3);
						x3 = double.NaN;
						sincosf_eval_double_unsigned_int_double_double_double_double.Invoke(xd, num, &num2, &num3, &x2, &x3);
						result = (float)fputil_multiply_add_double_double_double.Invoke(x2, 0.0 - num2, fputil_multiply_add_double_double_double.Invoke(x3, num3, num3));
						llvm_lifetime_end_p0.Invoke(8L, &x3);
						llvm_lifetime_end_p0.Invoke(8L, &x2);
						llvm_lifetime_end_p0.Invoke(8L, &num3);
						llvm_lifetime_end_p0.Invoke(8L, &num2);
					}
					break;
				}
			}
			llvm_lifetime_end_p0.Invoke(8L, &xd);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
