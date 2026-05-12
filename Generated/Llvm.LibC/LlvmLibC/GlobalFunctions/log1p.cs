using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class log1p
{
	public unsafe static double Invoke(double x)
	{
		int num = 0;
		int num2 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num3 = 0L;
		NumberPair numberPair = default(NumberPair);
		short num4 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		NumberPair numberPair2 = default(NumberPair);
		float num5 = 0f;
		float num6 = 0f;
		sbyte b = 0;
		sbyte b2 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		NumberPair numberPair3 = default(NumberPair);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		long num7 = 0L;
		int num8 = 0;
		int num9 = 0;
		double num10 = 0.0;
		double num11 = 0.0;
		double num12 = 0.0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		double z = 0.0;
		long num13 = 0L;
		long x2 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		long x3 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(fputil_FPBits_wjhbrm);
		NumberPair numberPair4 = default(NumberPair);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm12 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm13 = default(fputil_FPBits_wjhbrm);
		double num14 = 0.0;
		double a = 0.0;
		NumberPair numberPair5 = default(NumberPair);
		NumberPair numberPair6 = default(NumberPair);
		NumberPair numberPair7 = default(NumberPair);
		double x4 = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num15 = 0.0;
		double num16 = 0.0;
		double num17 = 0.0;
		double num18 = 0.0;
		NumberPair numberPair8 = default(NumberPair);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 1023;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 52;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.lo = 0.0;
			numberPair.hi = 0.0;
			llvm_lifetime_start_p0.Invoke(2L, &num4);
			num4 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			if ((ushort)num4 >= 1023)
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)num3 >= 5066549580791808000uL, expected: false))
				{
					long num19 = num3;
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal_Sign.Invoke(anon_izyfb8.val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
					bool num20 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)num19 > (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)), expected: false);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					if (num20)
					{
						if (num3 == -4616189618054758400L)
						{
							fputil_set_errno_if_required_int.Invoke(34);
							fputil_raise_except_if_required_int.Invoke(4);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_NEG.Pointer, 1L, isVolatile: false);
							long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb9.val);
							fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
							result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						}
						else if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) && !fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
						{
							fputil_set_errno_if_required_int.Invoke(33);
							fputil_raise_except_if_required_int.Invoke(1);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
							long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb10.val, 0L);
							fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
							result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						}
						else
						{
							result = x;
						}
						goto IL_0f84;
					}
					numberPair.hi = x;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
					Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_add_true_double_double.Invoke(x, 1.0);
					NumberPair* num21 = &numberPair2;
					Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
					*(double*)num21 = struct_4ydhja2.field_0;
					byte* num22 = (byte*)(&numberPair2) + 8u;
					Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
					*(double*)num22 = struct_4ydhja3.field_1;
					llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair2, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
				}
			}
			else
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) < 970, expected: false))
				{
					if (x == 0.0)
					{
						result = x + x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = 1f;
						llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = -1f;
						llvm_lifetime_start_p0.Invoke(1L, &b);
						b = (NumericHelper.IsUnorderedOrNotEquals(num5 - 2.9802322E-08f, num5) ? ((sbyte)1) : ((sbyte)0));
						llvm_lifetime_start_p0.Invoke(1L, &b2);
						b2 = (NumericHelper.IsUnorderedOrNotEquals(num6 - 5.9604645E-08f, num6) ? ((sbyte)1) : ((sbyte)0));
						if (x > 0.0 && (b & 1) == 1)
						{
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm6, num3 - 1L);
							result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						}
						else if (x < 0.0 && (b2 & 1) == 1)
						{
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm7, num3 + 1L);
							result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm7);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
						}
						else
						{
							result = ((x + x != 0.0) ? x : (x + x));
						}
						llvm_lifetime_end_p0.Invoke(1L, &b2);
						llvm_lifetime_end_p0.Invoke(1L, &b);
						llvm_lifetime_end_p0.Invoke(4L, &num6);
						llvm_lifetime_end_p0.Invoke(4L, &num5);
					}
					goto IL_0f84;
				}
				llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
				Struct_4ydhja struct_4ydhja4 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(1.0, x);
				NumberPair* num23 = &numberPair3;
				Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
				*(double*)num23 = struct_4ydhja5.field_0;
				byte* num24 = (byte*)(&numberPair3) + 8u;
				Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
				*(double*)num24 = struct_4ydhja6.field_1;
				llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair3, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			}
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			*(long*)(&fputil_FPBits_wjhbrm8) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm8, numberPair.hi);
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm8));
			num3 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm8));
			llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = (int)(num7 + 17592186044416L >>> 45);
			llvm_lifetime_start_p0.Invoke(4L, &num9);
		}
		num9 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent_const.Invoke(unchecked((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm8))) + (num8 >> 7);
		llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = num9;
		llvm_lifetime_start_p0.Invoke(8L, &num11);
		double x5 = num10;
		long num25 = num8;
		unchecked
		{
			num11 = fputil_multiply_add_double_double_double.Invoke(x5, 0.6931471805598903, ((NumberPair*)anonymous_namespace_LOG_R1_DD.Pointer)[num25].hi);
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			double x6 = num10;
			long num26 = num8;
			num12 = fputil_multiply_add_double_double_double.Invoke(x6, 5.497923018708371E-14, ((NumberPair*)anonymous_namespace_LOG_R1_DD.Pointer)[num26].lo);
			llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
			*(double*)(&inlineArray2_Double) = 2.5849394142282115E-26;
			((double*)(&inlineArray2_Double))[1] = 0.0;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, ((num11 == 0.0) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
			llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = checked((num3 & 0x7FF0000000000000L) - 4607182418800017408L);
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
			long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb11.val);
			fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val4;
			long num27 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm9)) | num7;
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			x2 = num27;
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm11, numberPair.lo);
			long val5 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm11));
			fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.val = val5;
			long num28 = ((!(fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm10) > numberPair.hi * 5.877471754111438E-39)) ? 0L : checked(cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const.Invoke(&numberPair.lo) - num13));
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			x3 = num28;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm12, x3);
			numberPair4.lo = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm12);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm13);
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm13, x2);
			numberPair4.hi = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm13);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm13);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
			llvm_lifetime_start_p0.Invoke(8L, &num14);
			long num29 = num8;
			num14 = ((double*)anonymous_namespace_R1.Pointer)[num29];
			llvm_lifetime_start_p0.Invoke(8L, &a);
			a = double.NaN;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = NumberPair_double_fputil_exact_mult_27ul_double_double.Invoke(numberPair4.lo, num14);
			NumberPair* num30 = &numberPair5;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num30 = struct_4ydhja8.field_0;
			byte* num31 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num31 = struct_4ydhja9.field_1;
			a = fputil_multiply_add_double_double_double.Invoke(num14, numberPair4.hi, -1.0);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja10 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(a, numberPair5.hi);
			NumberPair* num32 = &numberPair6;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num32 = struct_4ydhja11.field_0;
			byte* num33 = (byte*)(&numberPair6) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num33 = struct_4ydhja12.field_1;
			double lo = numberPair5.lo;
			numberPair6.lo += lo;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja13 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(num11, numberPair6.hi);
			NumberPair* num34 = &numberPair7;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num34 = struct_4ydhja14.field_0;
			byte* num35 = (byte*)(&numberPair7) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num35 = struct_4ydhja15.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &x4);
			x4 = numberPair6.hi * numberPair6.hi;
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(numberPair6.hi, ((double*)anonymous_namespace_P_COEFFS.Pointer)[1], *(double*)anonymous_namespace_P_COEFFS.Pointer);
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(numberPair6.hi, ((double*)anonymous_namespace_P_COEFFS.Pointer)[3L], ((double*)anonymous_namespace_P_COEFFS.Pointer)[2L]);
			llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = fputil_multiply_add_double_double_double.Invoke(numberPair6.hi, ((double*)anonymous_namespace_P_COEFFS.Pointer)[5L], ((double*)anonymous_namespace_P_COEFFS.Pointer)[4L]);
			llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double.Invoke(x4, numberPair6.lo + numberPair7.lo + num12, a_yc74sk, a_ijazrn, a_889uw);
			llvm_lifetime_start_p0.Invoke(8L, &num16);
			num16 = fputil_multiply_add_double_double_double.Invoke(x4, 1.7763568394002505E-15, z);
			llvm_lifetime_start_p0.Invoke(8L, &num17);
			num17 = numberPair7.hi + (num15 - num16);
			llvm_lifetime_start_p0.Invoke(8L, &num18);
			num18 = numberPair7.hi + (num15 + num16);
			if (num17 == num18)
			{
				result = num17;
			}
			else
			{
				int e_x = num9;
				int num36 = num8;
				llvm_memcpy_p0_p0_i64.Invoke(&numberPair8, &numberPair6, 16L, isVolatile: false);
				result = anonymous_namespace_log1p_accurate_int_int_NumberPair_double.Invoke(e_x, num36, *(double*)(&numberPair8), ((double*)(&numberPair8))[1]);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num18);
			llvm_lifetime_end_p0.Invoke(8L, &num17);
			llvm_lifetime_end_p0.Invoke(8L, &num16);
			llvm_lifetime_end_p0.Invoke(8L, &num15);
			llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &x4);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &num14);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num13);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(4L, &num9);
			llvm_lifetime_end_p0.Invoke(4L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			goto IL_0f84;
		}
		IL_0f84:
		llvm_lifetime_end_p0.Invoke(2L, &num4);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
