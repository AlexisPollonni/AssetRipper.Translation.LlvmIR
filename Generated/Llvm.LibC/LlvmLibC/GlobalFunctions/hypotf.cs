using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class hypotf
{
	public unsafe static float Invoke(float x, float y)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs9 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num7 = 0L;
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, x);
			int field_ = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			*(int*)(&fputil_FPBits_5nkvcs4) = -1431655766;
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs5, y);
			int field_2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs5));
			fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) >= (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4))) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
			*(int*)(&fputil_FPBits_5nkvcs6) = -1431655766;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs6, Unsafe.AsPointer(ref (b & 1) != 1 ? ref fputil_FPBits_5nkvcs4 : ref fputil_FPBits_5nkvcs2), 4L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
			*(int*)(&fputil_FPBits_5nkvcs7) = -1431655766;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs7, Unsafe.AsPointer(ref (b & 1) != 1 ? ref fputil_FPBits_5nkvcs2 : ref fputil_FPBits_5nkvcs4), 4L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs6));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs7));
			float result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num >= 2139095040u, expected: false))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan_const.Invoke(&fputil_FPBits_5nkvcs6) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan_const.Invoke(&fputil_FPBits_5nkvcs7))
				{
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs8);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs6) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs7))
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb9.val);
					fputil_FPBits_5nkvcs9.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs9);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
				}
				else
				{
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6);
				}
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)(num - num2) >= 209715200u, expected: false))
			{
				result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2) + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6);
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs7);
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = num3 * num3;
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = fputil_multiply_add_double_double_double.Invoke(num4, num4, num5);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_double_sizeof_double_sizeof_double_double_type_fputil_sqrt_double_double_double.Invoke(num6));
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((num7 + 1L) & 0xFFFFFFEL) == 0L, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = fputil_multiply_add_double_double_double.Invoke(num4, num4, num5 - num6);
					llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = num9 - fputil_multiply_add_double_double_double.Invoke(num8, num8, 0.0 - num6);
					if (num10 > 0.0)
					{
						num7 |= 1L;
					}
					else if (num10 < 0.0 && (num7 & 1L) == 0L)
					{
						num7--;
					}
					else if ((num7 & 0x1FFFFFFFL) == 0L)
					{
						fputil_clear_except_if_required_int.Invoke(32);
					}
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, num7);
					result = (float)fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &num10);
					llvm_lifetime_end_p0.Invoke(8L, &num9);
					llvm_lifetime_end_p0.Invoke(8L, &num8);
				}
				else
				{
					result = (float)fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
