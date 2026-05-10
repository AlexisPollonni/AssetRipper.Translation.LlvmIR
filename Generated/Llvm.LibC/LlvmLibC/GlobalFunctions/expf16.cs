using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expf16
{
	public unsafe static Half Invoke(Half x)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
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
		fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva9 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		float x2 = 0f;
		cpp_optional_aq7wey cpp_optional_aq7wey3 = default(cpp_optional_aq7wey);
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva2);
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(((uint)(ushort)num2 > 10240u) ? ((uint)(ushort)num2 >= 18944u) : true, expected: false))
			{
				goto IL_05f1;
			}
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
			else if (fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos_const.Invoke(&fputil_FPBits_2fahva2) && (uint)(ushort)num2 >= 18944u)
			{
				if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf_const.Invoke(&fputil_FPBits_2fahva2))
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb9.val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else
				{
					int num3 = fputil_quick_get_round.Invoke();
					if (num3 == 0 || num3 == 2048)
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(8);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_3 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb10.val);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva5);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal_Sign.Invoke(anon_izyfb11.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
				}
			}
			else if ((uint)(ushort)num >= 52352u)
			{
				if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf_const.Invoke(&fputil_FPBits_2fahva2))
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_5 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb12.val);
					fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva7);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
				else
				{
					fputil_set_errno_if_required_int.Invoke(34);
					fputil_raise_except_if_required_int.Invoke(48);
					if (fputil_quick_get_round.Invoke() == 2048)
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_6 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal_Sign.Invoke(anon_izyfb13.val);
						fputil_FPBits_2fahva8.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva8);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva9);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_7 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb14.val);
						fputil_FPBits_2fahva9.FPRepImpl.FPRepSem.FPStorage.field_0 = field_7;
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva9);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva9);
					}
				}
			}
			else
			{
				if ((uint)(ushort)num2 > 10240u || fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke(&fputil_FPBits_2fahva2))
				{
					goto IL_05f1;
				}
				llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = fputil_ExceptValues_Float16_2ul_lookup_unsigned_short_const.Invoke(x_bits: num, @this: EXPF16_EXCEPTS_LO.Pointer);
				*(int*)(&cpp_optional_aq7wey2.storage) = storage;
				int num4;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_Float16_has_value_const.Invoke(&cpp_optional_aq7wey2), expected: false))
				{
					result = *(Half*)cpp_optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
					num4 = 1;
				}
				else
				{
					num4 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
				switch (num4)
				{
				case 0:
					llvm_lifetime_start_p0.Invoke(4L, &x2);
					x2 = (float)x;
					result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float_float_float_float_float.Invoke(x2, 1f, 1f, 0.5000305f, 0.16667074f));
					llvm_lifetime_end_p0.Invoke(4L, &x2);
					break;
				}
			}
			goto IL_06e8;
		}
		IL_06e8:
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		return result;
		IL_05f1:
		llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey3);
		unchecked
		{
			sbyte* ptr2 = (sbyte*)(&cpp_optional_aq7wey3);
			*(Half*)ptr2 = default(Half);
			ptr2[2] = -86;
			ptr2[3] = -86;
			int storage2 = fputil_ExceptValues_Float16_3ul_lookup_unsigned_short_const.Invoke(x_bits: num, @this: EXPF16_EXCEPTS_HI.Pointer);
			*(int*)(&cpp_optional_aq7wey3.storage) = storage2;
			int num4;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_Float16_has_value_const.Invoke(&cpp_optional_aq7wey3), expected: false))
			{
				result = *(Half*)cpp_optional_Float16_value.Invoke(&cpp_optional_aq7wey3);
				num4 = 1;
			}
			else
			{
				num4 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey3);
			switch (num4)
			{
			case 0:
				llvm_lifetime_start_p0.Invoke(8L, &expRangeReduction);
				*(float*)(&expRangeReduction) = float.NaN;
				((float*)(&expRangeReduction))[1] = float.NaN;
				*(InlineArray2_Single*)(&expRangeReduction) = exp_range_reduction_Float16.Invoke(x);
				result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(expRangeReduction.exp_hi_mid * expRangeReduction.exp_lo);
				llvm_lifetime_end_p0.Invoke(8L, &expRangeReduction);
				break;
			}
			goto IL_06e8;
		}
	}
}
