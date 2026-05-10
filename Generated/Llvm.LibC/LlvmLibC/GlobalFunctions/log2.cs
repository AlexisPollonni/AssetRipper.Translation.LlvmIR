using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class log2
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
		double x2 = 0.0;
		double a = 0.0;
		long x3 = 0L;
		double y = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num8 = 0.0;
		NumberPair numberPair3 = default(NumberPair);
		NumberPair numberPair4 = default(NumberPair);
		double num9 = 0.0;
		double num10 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1023;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb8.val);
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq3, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
			bool num11 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double.Invoke(fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.val, fputil_internal_FPRepImpl_ucubaq3.FPRepSem.FPStorage.val), expected: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			if (num11)
			{
				result = 0.0;
			}
			else
			{
				long num12 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal_Sign.Invoke(anon_izyfb9.val);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
				bool num13 = (ulong)num12 < (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm4);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				int value;
				if (num13)
				{
					value = -1;
				}
				else
				{
					long num14 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal_Sign.Invoke(anon_izyfb10.val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
					value = (((ulong)num14 > (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm5)) ? 1 : 0);
				}
				bool num15 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((byte)value != 0, expected: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				if (!num15)
				{
					goto IL_04ce;
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
				else if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke(&fputil_FPBits_wjhbrm2) && !fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke(&fputil_FPBits_wjhbrm2))
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
					if (!fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm2))
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm8, x * 4503599627370496.0);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm8, 8L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
						num2 = checked(num2 - 52);
						num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm2);
						goto IL_04ce;
					}
					result = x;
				}
			}
			goto IL_0a5e;
		}
		IL_0a5e:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
		IL_04ce:
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = (int)(num >>> 45);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 & 0x7F;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			long num16 = num4;
			x2 = ((double*)RD.Pointer)[num16];
		}
		num2 += unchecked((int)(num + 35184372088832L >>> 52));
		llvm_lifetime_start_p0.Invoke(8L, &a);
		a = num2;
		llvm_lifetime_start_p0.Invoke(8L, &x3);
		x3 = (num & 0xFFFFFFFFFFFFFL) | 0x3FF0000000000000L;
		llvm_lifetime_start_p0.Invoke(8L, &y);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
		fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm9, x3);
		double num17 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm9);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
		y = num17;
		llvm_lifetime_start_p0.Invoke(8L, &num5);
		num5 = double.NaN;
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = double.NaN;
		llvm_lifetime_start_p0.Invoke(8L, &num7);
		num7 = double.NaN;
		llvm_lifetime_start_p0.Invoke(16L, &numberPair);
		unchecked
		{
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair);
			num5 = fputil_multiply_add_double_double_double.Invoke(x2, y, -1.0);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			long num18 = num4;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_add_true_double_double.Invoke(((NumberPair*)anonymous_namespace_LOG_R1.Pointer)[num18].hi, num5);
			NumberPair* num19 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num19 = struct_4ydhja2.field_0;
			byte* num20 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num20 = struct_4ydhja3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			num6 = num5 * num5;
			num7 = num6 * 1.7763568394002505E-15;
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num5, ((double*)LOG_COEFFS.Pointer)[1], *(double*)LOG_COEFFS.Pointer);
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num5, ((double*)LOG_COEFFS.Pointer)[3L], ((double*)LOG_COEFFS.Pointer)[2L]);
			llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = fputil_multiply_add_double_double_double.Invoke(num5, ((double*)LOG_COEFFS.Pointer)[5L], ((double*)LOG_COEFFS.Pointer)[4L]);
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			double x4 = num6;
			long num21 = num4;
			num8 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double.Invoke(x4, ((NumberPair*)anonymous_namespace_LOG_R1.Pointer)[num21].lo, a_yc74sk, a_ijazrn, a_889uw);
			numberPair.lo += num8;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, anonymous_namespace_LOG2_E.Pointer);
			NumberPair* num22 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num22 = struct_4ydhja5.field_0;
			byte* num23 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num23 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(a, numberPair3.hi);
			NumberPair* num24 = &numberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num24 = struct_4ydhja8.field_0;
			byte* num25 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num25 = struct_4ydhja9.field_1;
			double lo = numberPair3.lo;
			numberPair4.lo += lo;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = numberPair4.hi + (numberPair4.lo - num7);
			llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = numberPair4.hi + (numberPair4.lo + num7);
			result = ((num9 != num10) ? anonymous_namespace_log2_accurate_int_int_double.Invoke(num2, num4, num5) : num9);
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			goto IL_0a5e;
		}
	}
}
