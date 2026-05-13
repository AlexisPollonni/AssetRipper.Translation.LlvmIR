using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIfmNS1_24FModDivisionSimpleHelperImEEE13eval_internalENS0_6FPBitsIfEES7_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<float, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::eval_internal(__llvm_libc_20_1_2_::fputil::FPBits<float>, __llvm_libc_20_1_2_::fputil::FPBits<float>)")]
internal static partial class fputil_generic_FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_internal_fputil_FPBits_float_fputil_FPBits_float
{
	public unsafe static int Invoke([MangledName("sx.coerce")] int sx, [MangledName("sy.coerce")] int sy)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
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
		fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = sx;
		fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = sy;
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)) <= (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4)), expected: true))
			{
				if ((uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)) < (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4)))
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero_Sign.Invoke(anon_izyfb8.val);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (ushort)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4));
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 23 && checked(num - num2) <= 8, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = ((num != num2) ? ((int)((uint)(num3 << checked(num - num2)) % (uint)num4)) : (num3 - num4));
					if (num5 == 0)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero_Sign.Invoke(anon_izyfb9.val);
						fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					}
					else
					{
						int field_3 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value_unsigned_int_int.Invoke(num5, checked(num2 - 1));
						fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
				}
				else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 0 && num2 == 0, expected: false))
				{
					*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
					fputil_FPBits_float_FPBits.Invoke(&fputil_FPBits_5nkvcs2);
					fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2), (int)((uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)) % (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4))));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = (uint)fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs3);
					num = checked(num + -1);
					llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = (uint)fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = 40;
					llvm_lifetime_start_p0.Invoke(4L, &num9);
					num9 = 40;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num2 > 0, expected: true))
					{
						num2 = checked(num2 + -1);
					}
					else
					{
						num7 = (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4));
						num9 = cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(num7);
					}
					llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countr_zero_unsigned_long_unsigned_long.Invoke(num7);
					llvm_lifetime_start_p0.Invoke(4L, &sides_zeroes_count);
					checked
					{
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
						num13 = ((num11 >= 40) ? 40 : num11);
						num6 <<= unchecked((int)(uint)num13);
						num11 -= num13;
						llvm_lifetime_end_p0.Invoke(4L, &num13);
					}
					num6 = (long)((ulong)num6 % (ulong)num7);
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num6 == 0L, expected: false))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero_Sign.Invoke(anon_izyfb10.val);
						fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					}
					else if (num11 == 0)
					{
						int field_5 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value_unsigned_int_int.Invoke((int)num6, num2);
						fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
					}
					else
					{
						num6 = fputil_generic_FModDivisionSimpleHelper_unsigned_long_execute_int_int_unsigned_long_unsigned_long.Invoke(num11, sides_zeroes_count, num6, num7);
						int field_6 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value_unsigned_int_int.Invoke((int)num6, num2);
						fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
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
			return fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0;
		}
	}
}
