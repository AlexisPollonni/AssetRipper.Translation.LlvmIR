using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class log
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq3 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		int num3 = 0;
		int num4 = 0;
		double num5 = 0.0;
		double num6 = 0.0;
		double a = 0.0;
		double num7 = 0.0;
		long num8 = 0L;
		double num9 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		double num10 = 0.0;
		double x2 = 0.0;
		double num11 = 0.0;
		NumberPair numberPair = default(NumberPair);
		long x3 = 0L;
		double num12 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		NumberPair numberPair2 = default(NumberPair);
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num13 = 0.0;
		double num14 = 0.0;
		double num15 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1023;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb8.val);
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq3, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
			bool num16 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double.Invoke(fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.val, fputil_internal_FPRepImpl_ucubaq3.FPRepSem.FPStorage.val), expected: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			if (num16)
			{
				result = 0.0;
			}
			else
			{
				long num17 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal_Sign.Invoke(anon_izyfb9.val);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
				bool num18 = (ulong)num17 < (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				int value;
				if (num18)
				{
					value = -1;
				}
				else
				{
					long num19 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal_Sign.Invoke(anon_izyfb10.val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
					value = (((ulong)num19 > (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5))) ? 1 : 0);
				}
				bool num20 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((byte)value != 0, expected: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				if (!num20)
				{
					goto IL_04eb;
				}
				if (x == 0.0)
				{
					fputil_set_errno_if_required_int.Invoke(34);
					fputil_raise_except_if_required_int.Invoke(4);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_NEG.Pointer, 1L, isVolatile: false);
					long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb11.val);
					fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val4;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				}
				else if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) && !fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					long val5 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb12.val, 0L);
					fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val5;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm7);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				}
				else
				{
					if (!fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)))
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm8, x * 4503599627370496.0);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm8, 8L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						num2 = checked(num2 - 52);
						num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
						goto IL_04eb;
					}
					result = x;
				}
			}
			goto IL_0a77;
		}
		IL_0a77:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_04eb:
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = (int)(num >>> 45);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 & 0x7F;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			long num21 = num4;
			num5 = ((double*)RD.Pointer)[num21];
		}
		num2 += unchecked((int)(num + 35184372088832L >>> 52));
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = num2;
		llvm_lifetime_start_p0.Invoke(8L, &a);
		double x4 = num6;
		long num22 = num4;
		unchecked
		{
			a = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x4, 0.6931471805598903, ((NumberPair*)LOG_R_DD.Pointer)[num22].hi);
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			double x5 = num6;
			long num23 = num4;
			num7 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x5, 5.497923018708371E-14, ((NumberPair*)LOG_R_DD.Pointer)[num23].lo);
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = (num & 0xFFFFFFFFFFFFFL) | 0x3FF0000000000000L;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm9, num8);
			double num24 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm9);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			num9 = num24;
			llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = double.NaN;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair);
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = num8 & 0x3FFFE00000000000L;
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm10, x3);
			double num25 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm10);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			num12 = num25;
			double x6 = num5;
			double y = num9 - num12;
			long num26 = num4;
			num10 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x6, y, ((double*)CD.Pointer)[num26]);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_add_true_double_double.Invoke(a, num10);
			NumberPair* num27 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num27 = struct_4ydhja2.field_0;
			byte* num28 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num28 = struct_4ydhja3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			x2 = num10 * num10;
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num10, ((double*)LOG_COEFFS_34.Pointer)[1], *(double*)LOG_COEFFS_34.Pointer);
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num10, ((double*)LOG_COEFFS_34.Pointer)[3L], ((double*)LOG_COEFFS_34.Pointer)[2L]);
			llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num10, ((double*)LOG_COEFFS_34.Pointer)[5L], ((double*)LOG_COEFFS_34.Pointer)[4L]);
			llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double.Invoke(x2, num7 + numberPair.lo, a_yc74sk, a_ijazrn, a_889uw);
			num11 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x2, 8.881784197001252E-16, 2.5849394142282115E-26);
			llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = numberPair.hi + (num13 - num11);
			llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = numberPair.hi + (num13 + num11);
			result = ((num14 != num15) ? anonymous_namespace_log_accurate_int_int_double.Invoke(num2, num4, num10) : num14);
			llvm_lifetime_end_p0.Invoke(8L, &num15);
			llvm_lifetime_end_p0.Invoke(8L, &num14);
			llvm_lifetime_end_p0.Invoke(8L, &num13);
			llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			goto IL_0a77;
		}
	}
}
