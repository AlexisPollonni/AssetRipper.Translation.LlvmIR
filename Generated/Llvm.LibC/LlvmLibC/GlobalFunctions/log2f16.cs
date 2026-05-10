using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class log2f16
{
	public unsafe static Half Invoke(Half x)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		int num2 = 0;
		float num3 = 0f;
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		short num4 = 0;
		int num5 = 0;
		float x2 = 0f;
		float num6 = 0f;
		float num7 = 0f;
		float num8 = 0f;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva2);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((ushort)num == 0) ? true : (((ushort)num != 15360) ? ((uint)(ushort)num >= 31744u) : true), expected: false))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke(&fputil_FPBits_2fahva2))
				{
					if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan_const.Invoke(&fputil_FPBits_2fahva2))
					{
						fputil_raise_except_if_required_int.Invoke(1);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb8.val, 0);
						fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					}
					else
					{
						result = x;
					}
				}
				else if (((ushort)num & 0x7FFF) == 0)
				{
					fputil_raise_except_if_required_int.Invoke(4);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb9.val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else if ((ushort)num == 15360)
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb10.val);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva5);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				}
				else if ((uint)(ushort)num > 32768u)
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_4 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan_Sign_unsigned_short.Invoke(anon_izyfb11.val, 0);
					fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva6);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_5 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb12.val);
					fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva7);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = fputil_ExceptValues_Float16_2ul_lookup_unsigned_short_const.Invoke(x_bits: num, @this: LOG2F16_EXCEPTS.Pointer);
				*(int*)(&cpp_optional_aq7wey2.storage) = storage;
				int num9;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_Float16_has_value_const.Invoke(&cpp_optional_aq7wey2), expected: false))
				{
					result = *(Half*)cpp_optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
				switch (num9)
				{
				case 0:
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = -15;
					if (((ushort)num & 0x7C00) == 0)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = 1024f;
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva8, (Half)((float)fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2) * (float)cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(1024f)));
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva8, 2L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						num = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva2);
						num2 = checked(num2 - 10);
						llvm_lifetime_end_p0.Invoke(4L, &num3);
					}
					llvm_lifetime_start_p0.Invoke(2L, &num4);
					num4 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke(&fputil_FPBits_2fahva2);
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = (ushort)num4 >> 5;
					checked
					{
						num2 += unchecked((ushort)num) >> 10;
						fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent_unsigned_short.Invoke(&fputil_FPBits_2fahva2, 15);
						llvm_lifetime_start_p0.Invoke(4L, &x2);
					}
					x2 = (float)fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = fputil_multiply_add_float_float_float.Invoke(x2, *(float*)cpp_array_float_32ul_operator_unsigned_long_const.Invoke(Index: num5, @this: ONE_OVER_F_F_9.Pointer), -1f);
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = num6 * cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float_float_float.Invoke(num6, 1.442695f, -0.7216118f, 0.4811537f);
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = *(float*)cpp_array_float_32ul_operator_unsigned_long_const.Invoke(Index: num5, @this: LOG2F_F.Pointer) + num7;
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke((float)num2 + num8);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(4L, &x2);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					llvm_lifetime_end_p0.Invoke(2L, &num4);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
					break;
				}
			}
			llvm_lifetime_end_p0.Invoke(2L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
