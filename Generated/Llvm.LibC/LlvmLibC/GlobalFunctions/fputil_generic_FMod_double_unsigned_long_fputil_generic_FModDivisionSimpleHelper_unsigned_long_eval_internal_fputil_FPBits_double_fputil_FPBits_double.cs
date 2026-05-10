using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIdmNS1_24FModDivisionSimpleHelperImEEE13eval_internalENS0_6FPBitsIdEES7_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<double, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::eval_internal(__llvm_libc_20_1_2_::fputil::FPBits<double>, __llvm_libc_20_1_2_::fputil::FPBits<double>)")]
internal static partial class fputil_generic_FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_internal_fputil_FPBits_double_fputil_FPBits_double
{
	public unsafe static long Invoke([MangledName("sx.coerce")] long sx, [MangledName("sy.coerce")] long sy)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		long num6 = 0L;
		long num7 = 0L;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int sides_zeroes_count = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = sx;
		fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = sy;
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm3) <= (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm4), expected: true))
			{
				if ((ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm3) < (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm4))
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb8.val);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke(&fputil_FPBits_wjhbrm4);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 52 && checked(num - num2) <= 11, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_wjhbrm4);
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = ((num != num2) ? ((long)((ulong)(num3 << (int)(uint)checked(num - num2)) % (ulong)num4)) : (num3 - num4));
					if (num5 == 0L)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb9.val);
						fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val2;
					}
					else
					{
						long val3 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_make_value_unsigned_long_int.Invoke(num5, checked(num2 - 1));
						fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val3;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num5);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
				else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 0 && num2 == 0, expected: false))
				{
					*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
					fputil_FPBits_double_FPBits.Invoke(&fputil_FPBits_wjhbrm2);
					fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, (long)((ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm3) % (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm4)));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_wjhbrm3);
					checked
					{
						num += -1;
						llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_wjhbrm4);
						llvm_lifetime_start_p0.Invoke(4L, &num8);
						num8 = 11;
						llvm_lifetime_start_p0.Invoke(4L, &num9);
						num9 = 11;
						if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 0, expected: true))
						{
							num2 += -1;
						}
						else
						{
							num7 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm4);
							num9 = cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(num7);
						}
						llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countr_zero_unsigned_long_unsigned_long.Invoke(num7);
						llvm_lifetime_start_p0.Invoke(4L, &sides_zeroes_count);
						sides_zeroes_count = num9 + num10;
						llvm_lifetime_start_p0.Invoke(4L, &num11);
						num11 = num - num2;
						llvm_lifetime_start_p0.Invoke(4L, &num12);
						num12 = ((num11 >= num10) ? num10 : num11);
						num7 >>>= unchecked((int)(uint)num12);
						num11 -= num12;
						num2 += num12;
						llvm_lifetime_end_p0.Invoke(4L, &num12);
						llvm_lifetime_start_p0.Invoke(4L, &num13);
						num13 = ((num11 >= 11) ? 11 : num11);
						num6 <<= unchecked((int)(uint)num13);
						num11 -= num13;
						llvm_lifetime_end_p0.Invoke(4L, &num13);
					}
					num6 = (long)((ulong)num6 % (ulong)num7);
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num6 == 0L, expected: false))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
						long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb10.val);
						fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val4;
					}
					else if (num11 == 0)
					{
						long val5 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_make_value_unsigned_long_int.Invoke(num6, num2);
						fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val5;
					}
					else
					{
						num6 = fputil_generic_FModDivisionSimpleHelper_unsigned_long_execute_int_int_unsigned_long_unsigned_long.Invoke(num11, sides_zeroes_count, num6, num7);
						long val6 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_make_value_unsigned_long_int.Invoke(num6, num2);
						fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val6;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num11);
					llvm_lifetime_end_p0.Invoke(4L, &sides_zeroes_count);
					llvm_lifetime_end_p0.Invoke(4L, &num10);
					llvm_lifetime_end_p0.Invoke(4L, &num9);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(8L, &num7);
					llvm_lifetime_end_p0.Invoke(8L, &num6);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val;
		}
	}
}
