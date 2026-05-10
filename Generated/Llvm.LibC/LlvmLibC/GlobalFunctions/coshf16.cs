using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class coshf16
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
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		cpp_optional_aq7wey cpp_optional_aq7wey3 = default(cpp_optional_aq7wey);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva2);
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)(ushort)num2 >= 18917u, expected: false))
			{
				goto IL_0300;
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
			else
			{
				if ((uint)(ushort)num2 < 18917u)
				{
					goto IL_0300;
				}
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
						fputil_raise_except_if_required_int.Invoke(40);
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
			goto IL_0451;
		}
		IL_0451:
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		return result;
		IL_0300:
		unchecked
		{
			if (fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos_const.Invoke(&fputil_FPBits_2fahva2))
			{
				llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = fputil_ExceptValues_Float16_9ul_lookup_unsigned_short_const.Invoke(x_bits: num, @this: COSHF16_EXCEPTS_POS.Pointer);
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
					break;
				default:
					goto IL_0451;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey3);
				sbyte* ptr2 = (sbyte*)(&cpp_optional_aq7wey3);
				*(Half*)ptr2 = default(Half);
				ptr2[2] = -86;
				ptr2[3] = -86;
				int storage2 = fputil_ExceptValues_Float16_4ul_lookup_unsigned_short_const.Invoke(x_bits: num, @this: COSHF16_EXCEPTS_NEG.Pointer);
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
					break;
				default:
					goto IL_0451;
				}
			}
			result = Float16_eval_sinh_or_cosh_false_Float16.Invoke(x);
			goto IL_0451;
		}
	}
}
