using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cospif16
{
	public unsafe static Half Invoke(Half x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		float xf = 0f;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float y = 0f;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			llvm_lifetime_start_p0.Invoke(4L, &xf);
			xf = (float)x;
			Half result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num2 == 0, expected: false))
			{
				result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(1f);
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num2 >= 25600, expected: false))
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num2 <= 26623, expected: false))
				{
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(InstructionHelper.Select(((ushort)num2 & 1) != 0, -1f, 1f));
				}
				else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num2 >= 31744, expected: false))
				{
					if ((ushort)num2 == 31744)
					{
						fputil_set_errno_if_required_int.Invoke(33);
						fputil_raise_except_if_required_int.Invoke(1);
					}
					float num6 = (float)x;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num6 + (float)fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else
				{
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(1f);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = float.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &y);
				y = float.NaN;
				sincospif16_eval_float_float_float_float_float.Invoke(xf, &num3, &num4, &num5, &y);
				result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num5 == 0f && num4 == 0f, expected: false)) ? cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(fputil_multiply_add_float_float_float.Invoke(num4, y, fputil_multiply_add_float_float_float.Invoke(0f - num3, num5, num4))) : cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(0f));
				llvm_lifetime_end_p0.Invoke(4L, &y);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &xf);
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
