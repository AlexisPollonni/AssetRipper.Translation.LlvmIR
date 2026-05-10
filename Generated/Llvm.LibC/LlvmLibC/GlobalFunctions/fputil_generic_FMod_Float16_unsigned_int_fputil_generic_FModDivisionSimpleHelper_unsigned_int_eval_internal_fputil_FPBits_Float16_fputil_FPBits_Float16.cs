using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIDF16_jNS1_24FModDivisionSimpleHelperIjEEE13eval_internalENS0_6FPBitsIDF16_EES7_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<_Float16, unsigned int, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>>::eval_internal(__llvm_libc_20_1_2_::fputil::FPBits<_Float16>, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>)")]
internal static partial class fputil_generic_FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval_internal_fputil_FPBits_Float16_fputil_FPBits_Float16
{
	public unsafe static short Invoke([MangledName("sx.coerce")] short sx, [MangledName("sy.coerce")] short sy)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		int num2 = 0;
		short num3 = 0;
		short num4 = 0;
		short num5 = 0;
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int sides_zeroes_count = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = sx;
		fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = sy;
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva3) <= (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva4), expected: true))
			{
				if ((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva3) < (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva4))
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb8.val);
					fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_biased_exponent_const.Invoke(&fputil_FPBits_2fahva3);
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_biased_exponent_const.Invoke(&fputil_FPBits_2fahva4);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 10 && checked(num - num2) <= 5, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(2L, &num3);
					num3 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa_const.Invoke(&fputil_FPBits_2fahva3);
					llvm_lifetime_start_p0.Invoke(2L, &num4);
					num4 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa_const.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_start_p0.Invoke(2L, &num5);
					num5 = (short)((num != num2) ? ((ushort)(short)((ushort)num3 << checked(num - num2)) % (ushort)num4) : checked(unchecked((ushort)num3) - unchecked((ushort)num4)));
					if ((ushort)num5 == 0)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_2 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb9.val);
						fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					}
					else
					{
						short field_3 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_make_value_unsigned_short_int.Invoke(num5, checked(num2 - 1));
						fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					}
					llvm_lifetime_end_p0.Invoke(2L, &num5);
					llvm_lifetime_end_p0.Invoke(2L, &num4);
					llvm_lifetime_end_p0.Invoke(2L, &num3);
				}
				else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 0 && num2 == 0, expected: false))
				{
					*(short*)(&fputil_FPBits_2fahva2) = -21846;
					fputil_FPBits_Float16_FPBits.Invoke(&fputil_FPBits_2fahva2);
					fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa_unsigned_short.Invoke(&fputil_FPBits_2fahva2, (short)((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva3) % (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke(&fputil_FPBits_2fahva4)));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = (ushort)fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa_const.Invoke(&fputil_FPBits_2fahva3);
					num = checked(num + -1);
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = (ushort)fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa_const.Invoke(&fputil_FPBits_2fahva4);
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = 21;
					llvm_lifetime_start_p0.Invoke(4L, &num9);
					num9 = 21;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 0, expected: true))
					{
						num2 = checked(num2 + -1);
					}
					else
					{
						num7 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke(&fputil_FPBits_2fahva4);
						num9 = cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countl_zero_unsigned_int_unsigned_int.Invoke(num7);
					}
					llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countr_zero_unsigned_int_unsigned_int.Invoke(num7);
					llvm_lifetime_start_p0.Invoke(4L, &sides_zeroes_count);
					checked
					{
						sides_zeroes_count = num9 + num10;
						llvm_lifetime_start_p0.Invoke(4L, &num11);
						num11 = num - num2;
						llvm_lifetime_start_p0.Invoke(4L, &num12);
						num12 = ((num11 >= num10) ? num10 : num11);
						num7 >>>= num12;
						num11 -= num12;
						num2 += num12;
						llvm_lifetime_end_p0.Invoke(4L, &num12);
						llvm_lifetime_start_p0.Invoke(4L, &num13);
						num13 = ((num11 >= 21) ? 21 : num11);
						num6 <<= num13;
						num11 -= num13;
						llvm_lifetime_end_p0.Invoke(4L, &num13);
					}
					num6 = (int)((uint)num6 % (uint)num7);
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num6 == 0, expected: false))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero_Sign.Invoke(anon_izyfb10.val);
						fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					}
					else if (num11 == 0)
					{
						short field_5 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_make_value_unsigned_short_int.Invoke((short)num6, num2);
						fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					}
					else
					{
						num6 = fputil_generic_FModDivisionSimpleHelper_unsigned_int_execute_int_int_unsigned_int_unsigned_int.Invoke(num11, sides_zeroes_count, num6, num7);
						short field_6 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_make_value_unsigned_short_int.Invoke((short)num6, num2);
						fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num11);
					llvm_lifetime_end_p0.Invoke(4L, &sides_zeroes_count);
					llvm_lifetime_end_p0.Invoke(4L, &num10);
					llvm_lifetime_end_p0.Invoke(4L, &num9);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0;
		}
	}
}
