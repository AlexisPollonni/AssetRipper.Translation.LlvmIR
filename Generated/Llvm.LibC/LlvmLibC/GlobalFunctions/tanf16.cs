using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tanf16
{
	public unsafe static Half Invoke(Half x)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		sbyte b = 0;
		float num3 = 0f;
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		int num4 = 0;
		float x2 = 0f;
		float num5 = 0f;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		float num6 = 0f;
		float num7 = 0f;
		float x3 = 0f;
		float x4 = 0f;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((ushort)num >> 15 != 0) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (float)x;
			llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
			sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
			*(Half*)ptr = default(Half);
			ptr[2] = -86;
			ptr[3] = -86;
			int storage = fputil_ExceptValues_Float16_9ul_lookup_odd_unsigned_short_bool_const.Invoke(x_abs: num2, sign: (b & 1) == 1, @this: TANF16_EXCEPTS.Pointer);
			*(int*)(&cpp_optional_aq7wey2.storage) = storage;
			int num8;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_Float16_has_value_const.Invoke(&cpp_optional_aq7wey2), expected: false))
			{
				result = *(Half*)cpp_optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
				num8 = 1;
			}
			else
			{
				num8 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
			switch (num8)
			{
			case 0:
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num2 <= 11076, expected: false))
				{
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num2 <= 4326, expected: false))
					{
						if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num2 == 0, expected: false))
						{
							result = x;
							break;
						}
						llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = fputil_quick_get_round.Invoke();
						result = (((!fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) || num4 != 2048) && (!fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) || num4 != 1024)) ? x : cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(num3, 0.00048828125f, num3)));
						llvm_lifetime_end_p0.Invoke(4L, &num4);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &x2);
						x2 = num3 * num3;
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float_float_float_float_float.Invoke(x2, 1f, 1f / 3f, 0.13332918f, 0.054504853f);
						result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(num3 * num5);
						llvm_lifetime_end_p0.Invoke(4L, &num5);
						llvm_lifetime_end_p0.Invoke(4L, &x2);
					}
				}
				else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num2 >= 31744, expected: false))
				{
					if ((ushort)num2 == 31744)
					{
						fputil_set_errno_if_required_int.Invoke(33);
						fputil_raise_except_if_required_int.Invoke(1);
					}
					float num9 = (float)x;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num9 + (float)fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &x3);
					x3 = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &x4);
					x4 = float.NaN;
					sincosf16_eval_float_float_float_float_float.Invoke(num3, &num6, &num7, &x3, &x4);
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(x3, num7, cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(x4, num6, num6)) / cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(x3, 0f - num6, cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(x4, num7, num7)));
					llvm_lifetime_end_p0.Invoke(4L, &x4);
					llvm_lifetime_end_p0.Invoke(4L, &x3);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
				break;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
