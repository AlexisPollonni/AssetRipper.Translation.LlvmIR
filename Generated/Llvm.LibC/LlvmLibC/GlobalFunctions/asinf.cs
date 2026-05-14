using System;
using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class asinf
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		int num3 = 0;
		double num4 = 0.0;
		cpp_optional_xmxtsi cpp_optional_xmxtsi2 = default(cpp_optional_xmxtsi);
		double num5 = 0.0;
		double num6 = 0.0;
		double x2 = 0.0;
		double y = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		cpp_optional_xmxtsi cpp_optional_xmxtsi3 = default(cpp_optional_xmxtsi);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num7 = 0.0;
		double y2 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double z = 0.0;
		double x3 = 0.0;
		double y3 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) & 0x7FFFFFFF;
			llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = num >>> 31;
			if ((uint)num2 < 1057244957u)
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num2 < 971544424u, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = x;
					result = (float)cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num4, 2.980232238769531E-08, num4);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi2);
					sbyte* ptr = (sbyte*)(&cpp_optional_xmxtsi2);
					*(float*)ptr = float.NaN;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = fputil_ExceptValues_float_2ul_lookup_odd_unsigned_int_bool_const.Invoke(x_abs: num2, sign: num3 != 0, @this: ASINF_EXCEPTS_LO.Pointer);
					*(long*)(&cpp_optional_xmxtsi2.storage) = storage;
					int num10;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_float_has_value_const.Invoke(&cpp_optional_xmxtsi2), expected: false))
					{
						result = *(float*)cpp_optional_float_value.Invoke(&cpp_optional_xmxtsi2);
						num10 = 1;
					}
					else
					{
						num10 = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi2);
					switch (num10)
					{
					case 0:
						llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = x;
						llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = num5 * num5;
						llvm_lifetime_start_p0.Invoke(8L, &x2);
						x2 = num5 * num6;
						llvm_lifetime_start_p0.Invoke(8L, &y);
						y = asin_eval_double.Invoke(num6);
						result = (float)cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x2, y, num5);
						llvm_lifetime_end_p0.Invoke(8L, &y);
						llvm_lifetime_end_p0.Invoke(8L, &x2);
						llvm_lifetime_end_p0.Invoke(8L, &num6);
						llvm_lifetime_end_p0.Invoke(8L, &num5);
						break;
					}
				}
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num2 > 1065353216u, expected: false))
			{
				if ((uint)num2 <= 2139095040u)
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb8.val, 0);
				fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi3);
				sbyte* ptr3 = (sbyte*)(&cpp_optional_xmxtsi3);
				*(float*)ptr3 = float.NaN;
				ptr3[4] = -86;
				sbyte* ptr4 = ptr3 + 5;
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				long storage2 = fputil_ExceptValues_float_2ul_lookup_odd_unsigned_int_bool_const.Invoke(x_abs: num2, sign: num3 != 0, @this: ASINF_EXCEPTS_HI.Pointer);
				*(long*)(&cpp_optional_xmxtsi3.storage) = storage2;
				int num10;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_float_has_value_const.Invoke(&cpp_optional_xmxtsi3), expected: false))
				{
					result = *(float*)cpp_optional_float_value.Invoke(&cpp_optional_xmxtsi3);
					num10 = 1;
				}
				else
				{
					num10 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi3);
				switch (num10)
				{
				case 0:
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb9.val);
					llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (nint)(uint)num3 * (nint)sizeof(double)));
					llvm_lifetime_start_p0.Invoke(8L, &y2);
					y2 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(-0.5, y2, 0.5);
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = num7 * (-2.0 * cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_double_sizeof_double_sizeof_double_double_type_fputil_sqrt_double_double_double.Invoke(num8));
					llvm_lifetime_start_p0.Invoke(8L, &z);
					z = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num7, Math.PI / 2.0, num9);
					llvm_lifetime_start_p0.Invoke(8L, &x3);
					x3 = num9 * num8;
					llvm_lifetime_start_p0.Invoke(8L, &y3);
					y3 = asin_eval_double.Invoke(num8);
					result = (float)cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x3, y3, z);
					llvm_lifetime_end_p0.Invoke(8L, &y3);
					llvm_lifetime_end_p0.Invoke(8L, &x3);
					llvm_lifetime_end_p0.Invoke(8L, &z);
					llvm_lifetime_end_p0.Invoke(8L, &num9);
					llvm_lifetime_end_p0.Invoke(8L, &num8);
					llvm_lifetime_end_p0.Invoke(8L, &y2);
					llvm_lifetime_end_p0.Invoke(8L, &num7);
					break;
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
