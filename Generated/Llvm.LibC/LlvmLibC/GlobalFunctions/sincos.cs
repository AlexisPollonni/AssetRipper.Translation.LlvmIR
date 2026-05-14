using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sincos
{
	public unsafe static void Invoke(double x, void* sin_x, void* cos_x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		short num = 0;
		NumberPair numberPair = default(NumberPair);
		int num2 = 0;
		LargeRangeReduction largeRangeReduction = default(LargeRangeReduction);
		int num3 = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double num4 = 0.0;
		NumberPair numberPair4 = default(NumberPair);
		NumberPair numberPair5 = default(NumberPair);
		NumberPair numberPair6 = default(NumberPair);
		NumberPair numberPair7 = default(NumberPair);
		NumberPair numberPair8 = default(NumberPair);
		NumberPair numberPair9 = default(NumberPair);
		NumberPair numberPair10 = default(NumberPair);
		NumberPair numberPair11 = default(NumberPair);
		NumberPair numberPair12 = default(NumberPair);
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		double num11 = 0.0;
		double num12 = 0.0;
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(fputil_DyadicFloat_kt2kd4);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd11 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd12 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd13 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd14 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd15 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd16 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd17 = default(fputil_DyadicFloat_kt2kd4);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd18 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		int num13;
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
						if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(x == 0.0, expected: false))
						{
							*(double*)sin_x = x;
							*(double*)cos_x = 1.0;
							num13 = 1;
							goto IL_109e;
						}
						*(double*)cos_x = double_fputil_round_result_slightly_down_double_double.Invoke(1.0);
						if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num < 4, expected: false))
						{
							goto IL_048d;
						}
						llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = fputil_quick_get_round.Invoke();
						if (num3 != 3072)
						{
							anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
							if (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val) || num3 != 1024)
							{
								anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_NEG.Pointer, 1L, isVolatile: false);
								if (!operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val) || num3 != 2048)
								{
									goto IL_047b;
								}
							}
						}
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) - 1L);
						*(double*)sin_x = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						goto IL_047b;
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
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb12.val, 0L);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
					*(double*)sin_x = (*(double*)cos_x = x + fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4));
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					num13 = 1;
					goto IL_109e;
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
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = generic_sincos_eval_NumberPair_double_const_NumberPair_double_NumberPair_double.Invoke(&numberPair, &numberPair2, &numberPair3);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			long num14 = (uint)(num2 & 0xFF);
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair4, (byte*)SIN_K_PI_OVER_128.Pointer + (nint)num14 * sizeof(NumberPair), 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			long num15 = (uint)((num2 + 64) & 0xFF);
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair5, (byte*)SIN_K_PI_OVER_128.Pointer + (nint)num15 * sizeof(NumberPair), 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			numberPair6.lo = 0.0 - numberPair4.lo;
			numberPair6.hi = 0.0 - numberPair4.hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair3, &numberPair4);
			NumberPair* num16 = &numberPair7;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num16 = struct_4ydhja2.field_0;
			byte* num17 = (byte*)(&numberPair7) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num17 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair8);
			*(double*)(&numberPair8) = double.NaN;
			((double*)(&numberPair8))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair2, &numberPair5);
			NumberPair* num18 = &numberPair8;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num18 = struct_4ydhja5.field_0;
			byte* num19 = (byte*)(&numberPair8) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num19 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair9);
			*(double*)(&numberPair9) = double.NaN;
			((double*)(&numberPair9))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair3, &numberPair5);
			NumberPair* num20 = &numberPair9;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num20 = struct_4ydhja8.field_0;
			byte* num21 = (byte*)(&numberPair9) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num21 = struct_4ydhja9.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair10);
			*(double*)(&numberPair10) = double.NaN;
			((double*)(&numberPair10))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja10 = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair2, &numberPair6);
			NumberPair* num22 = &numberPair10;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num22 = struct_4ydhja11.field_0;
			byte* num23 = (byte*)(&numberPair10) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num23 = struct_4ydhja12.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair11);
			*(double*)(&numberPair11) = double.NaN;
			((double*)(&numberPair11))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja13 = NumberPair_double_fputil_exact_add_false_double_double.Invoke(numberPair7.hi, numberPair8.hi);
			NumberPair* num24 = &numberPair11;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num24 = struct_4ydhja14.field_0;
			byte* num25 = (byte*)(&numberPair11) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num25 = struct_4ydhja15.field_1;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair12);
			*(double*)(&numberPair12) = double.NaN;
			((double*)(&numberPair12))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja16 = NumberPair_double_fputil_exact_add_false_double_double.Invoke(numberPair9.hi, numberPair10.hi);
			NumberPair* num26 = &numberPair12;
			Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
			*(double*)num26 = struct_4ydhja17.field_0;
			byte* num27 = (byte*)(&numberPair12) + 8u;
			Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
			*(double*)num27 = struct_4ydhja18.field_1;
			double num28 = numberPair7.lo + numberPair8.lo;
			numberPair11.lo += num28;
			double num29 = numberPair10.lo + numberPair9.lo;
			numberPair12.lo += num29;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = numberPair11.lo + num4;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = numberPair11.lo - num4;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = numberPair12.lo + num4;
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = numberPair12.lo - num4;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = numberPair11.hi + num5;
			llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = numberPair11.hi + num6;
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = numberPair12.hi + num7;
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = numberPair12.hi + num8;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num9 == num10 && num11 == num12, expected: true))
			{
				*(double*)sin_x = num9;
				*(double*)cos_x = num11;
				num13 = 1;
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
					range_reduction_small_f128_double_16.Invoke(&fputil_DyadicFloat_kt2kd8, x);
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
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb13);
				*(sbyte*)(&anon_izyfb13) = -86;
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
				sincos_impl_double_double_double_0_operator_unsigned_int_const.Invoke(&fputil_DyadicFloat_kt2kd10, &anon_izyfb13, num2);
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
				sincos_impl_double_double_double_0_operator_unsigned_int_const.Invoke(&fputil_DyadicFloat_kt2kd11, &anon_izyfb13, num2 + 64);
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
				sincos_impl_double_double_double_0_operator_unsigned_int_const.Invoke(&fputil_DyadicFloat_kt2kd12, &anon_izyfb13, num2 + 128);
				if (num9 == num10)
				{
					*(double*)sin_x = num9;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd13);
					fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd7);
					fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd15, &fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd6);
					fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd15);
					*(double*)sin_x = fputil_DyadicFloat_128ul_operator_double_double_void_const.Invoke(&fputil_DyadicFloat_kt2kd13);
					llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd13);
				}
				if (num11 == num12)
				{
					*(double*)cos_x = num11;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
					fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd7);
					fputil_DyadicFloat_128ul_fputil_quick_mul_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const.Invoke(&fputil_DyadicFloat_kt2kd18, &fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd6);
					fputil_DyadicFloat_128ul_fputil_quick_add_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd16, &fputil_DyadicFloat_kt2kd17, &fputil_DyadicFloat_kt2kd18);
					*(double*)cos_x = fputil_DyadicFloat_128ul_operator_double_double_void_const.Invoke(&fputil_DyadicFloat_kt2kd16);
					llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd16);
				}
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd11);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd10);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb13);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
				llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				num13 = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair12);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair11);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair10);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair9);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair8);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			goto IL_109e;
		}
		IL_109e:
		llvm_lifetime_end_p0.Invoke(48L, &largeRangeReduction);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		switch (num13)
		{
		case 0:
		case 1:
			return;
		}
		throw new NotImplementedException("Reached LLVM unreachable instruction.");
		IL_047b:
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_048d;
		IL_048d:
		*unchecked((double*)sin_x) = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, -5.551115123125783E-17, x);
		num13 = 1;
		goto IL_109e;
	}
}
