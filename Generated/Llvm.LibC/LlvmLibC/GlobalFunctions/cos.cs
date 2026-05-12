using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cos
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		short num = 0;
		NumberPair numberPair = default(NumberPair);
		int num2 = 0;
		LargeRangeReduction largeRangeReduction = default(LargeRangeReduction);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num3 = 0.0;
		NumberPair numberPair4 = default(NumberPair);
		NumberPair numberPair5 = default(NumberPair);
		NumberPair numberPair6 = default(NumberPair);
		NumberPair numberPair7 = default(NumberPair);
		NumberPair numberPair8 = default(NumberPair);
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(fputil_DyadicFloat_kt2kd4);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd11 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd12 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd13 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd14 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1431655766;
			llvm_lifetime_start_p0.Invoke(48L, &largeRangeReduction);
			*(int*)(&largeRangeReduction) = -1431655766;
			sbyte* ptr = (sbyte*)(&largeRangeReduction) + 4;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((double*)(&largeRangeReduction))[1] = double.NaN;
			((double*)(&largeRangeReduction))[2] = double.NaN;
			((double*)(&largeRangeReduction))[3] = double.NaN;
			sbyte* ptr2 = (sbyte*)(&largeRangeReduction) + 32;
			*(double*)ptr2 = double.NaN;
			((double*)ptr2)[1] = double.NaN;
			llvm_memset_p0_i64.Invoke(&largeRangeReduction, 0, 48L, isVolatile: false);
			LargeRangeReduction_LargeRangeReduction.Invoke(&largeRangeReduction);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num < 1039, expected: true))
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num < 1016, expected: false))
				{
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num < 996, expected: false))
					{
						result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(x == 0.0, expected: false)) ? double_fputil_round_result_slightly_down_double_double.Invoke(1.0) : 1.0);
						goto IL_0b55;
					}
					num2 = 0;
					numberPair.lo = 0.0;
					numberPair.hi = x;
				}
				else
				{
					num2 = range_reduction_small_double_NumberPair_double.Invoke(x, &numberPair);
				}
			}
			else
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num > 2046, expected: false))
				{
					if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) == 0L)
					{
						fputil_set_errno_if_required_int.Invoke(33);
						fputil_raise_except_if_required_int.Invoke(1);
					}
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb8.val, 0L);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
					result = x + fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					goto IL_0b55;
				}
				num2 = LargeRangeReduction_fast_double_NumberPair_double.Invoke(&largeRangeReduction, x, &numberPair);
			}
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair2);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair3);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = generic_sincos_eval_NumberPair_double_const_NumberPair_double_NumberPair_double.Invoke(&numberPair, &numberPair2, &numberPair3);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			long num8 = (uint)((num2 + 128) & 0xFF);
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair4, (byte*)SIN_K_PI_OVER_128.Pointer + (nint)num8 * sizeof(NumberPair), 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			long num9 = (uint)((num2 + 64) & 0xFF);
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair5, (byte*)SIN_K_PI_OVER_128.Pointer + (nint)num9 * sizeof(NumberPair), 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair3, &numberPair5);
			NumberPair* num10 = &numberPair6;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num10 = struct_4ydhja2.field_0;
			byte* num11 = (byte*)(&numberPair6) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num11 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair2, &numberPair4);
			NumberPair* num12 = &numberPair7;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num12 = struct_4ydhja5.field_0;
			byte* num13 = (byte*)(&numberPair7) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num13 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair8);
			*(double*)(&numberPair8) = double.NaN;
			((double*)(&numberPair8))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = NumberPair_double_fputil_exact_add_false_double_double.Invoke(numberPair6.hi, numberPair7.hi);
			NumberPair* num14 = &numberPair8;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num14 = struct_4ydhja8.field_0;
			byte* num15 = (byte*)(&numberPair8) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num15 = struct_4ydhja9.field_1;
			double num16 = numberPair7.lo + numberPair6.lo;
			numberPair8.lo += num16;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = numberPair8.lo + num3;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = numberPair8.lo - num3;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = numberPair8.hi + num4;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = numberPair8.hi + num5;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num6 == num7, expected: true))
			{
				result = num6;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
				sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
				sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
				*(long*)ptr4 = -6148914691236517206L;
				((long*)ptr4)[1] = -6148914691236517206L;
				fputil_DyadicFloat_128ul_DyadicFloat.Invoke(&fputil_DyadicFloat_kt2kd5);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd6) = -86;
				sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 1;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
				sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
				*(long*)ptr6 = -6148914691236517206L;
				((long*)ptr6)[1] = -6148914691236517206L;
				fputil_DyadicFloat_128ul_DyadicFloat.Invoke(&fputil_DyadicFloat_kt2kd6);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd7) = -86;
				sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 1;
				*ptr7 = -86;
				ptr7[1] = -86;
				ptr7[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
				sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 8;
				*(long*)ptr8 = -6148914691236517206L;
				((long*)ptr8)[1] = -6148914691236517206L;
				fputil_DyadicFloat_128ul_DyadicFloat.Invoke(&fputil_DyadicFloat_kt2kd7);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num < 1039, expected: true))
				{
					llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
					range_reduction_small_f128_double_56.Invoke(&fputil_DyadicFloat_kt2kd8, x);
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd8, 24L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd9);
					LargeRangeReduction_accurate_const.Invoke(&fputil_DyadicFloat_kt2kd9, &largeRangeReduction);
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd9, 24L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd9);
				}
				generic_sincos_eval_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd5, &fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd7);
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
				*(sbyte*)(&anon_izyfb9) = -86;
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd10) = -86;
				sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd10) + 1;
				*ptr9 = -86;
				ptr9[1] = -86;
				ptr9[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd10))[1] = -1431655766;
				sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd10) + 8;
				*(long*)ptr10 = -6148914691236517206L;
				((long*)ptr10)[1] = -6148914691236517206L;
				cos_impl_double_0_operator_unsigned_int_const.Invoke(&fputil_DyadicFloat_kt2kd10, &anon_izyfb9, num2 + 128);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd11) = -86;
				sbyte* ptr11 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 1;
				*ptr11 = -86;
				ptr11[1] = -86;
				ptr11[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd11))[1] = -1431655766;
				sbyte* ptr12 = (sbyte*)(&fputil_DyadicFloat_kt2kd11) + 8;
				*(long*)ptr12 = -6148914691236517206L;
				((long*)ptr12)[1] = -6148914691236517206L;
				cos_impl_double_0_operator_unsigned_int_const.Invoke(&fputil_DyadicFloat_kt2kd11, &anon_izyfb9, num2 + 64);
				llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd12) = -86;
				sbyte* ptr13 = (sbyte*)(&fputil_DyadicFloat_kt2kd12) + 1;
				*ptr13 = -86;
				ptr13[1] = -86;
				ptr13[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd12))[1] = -1431655766;
				sbyte* ptr14 = (sbyte*)(&fputil_DyadicFloat_kt2kd12) + 8;
				*(long*)ptr14 = -6148914691236517206L;
				((long*)ptr14)[1] = -6148914691236517206L;
				fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd7);
				fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd6);
				fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14);
				result = fputil_DyadicFloat_128ul_operator_double_double_void_const.Invoke(&fputil_DyadicFloat_kt2kd12);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair8);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			goto IL_0b55;
		}
		IL_0b55:
		llvm_lifetime_end_p0.Invoke(48L, &largeRangeReduction);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
	}
}
