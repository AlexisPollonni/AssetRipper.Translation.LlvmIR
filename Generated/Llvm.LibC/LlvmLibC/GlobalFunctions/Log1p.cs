using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Log1p
{
	[MangledName("log1p")]
	[DemangledName("log1p")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		int num = 0;
		int num2 = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		long num3 = 0L;
		NumberPair numberPair = default(NumberPair);
		short num4 = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		NumberPair numberPair2 = default(NumberPair);
		float num5 = 0f;
		float num6 = 0f;
		sbyte b = 0;
		sbyte b2 = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(Fputil_FPBits_wjhbrm);
		NumberPair numberPair3 = default(NumberPair);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(Fputil_FPBits_wjhbrm);
		long num7 = 0L;
		int num8 = 0;
		int num9 = 0;
		double num10 = 0.0;
		double num11 = 0.0;
		double num12 = 0.0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		double z = 0.0;
		long num13 = 0L;
		long x = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		long x2 = 0L;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(Fputil_FPBits_wjhbrm);
		NumberPair numberPair4 = default(NumberPair);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm12 = default(Fputil_FPBits_wjhbrm);
		double num14 = 0.0;
		double a = 0.0;
		NumberPair numberPair5 = default(NumberPair);
		double num15 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm13 = default(Fputil_FPBits_wjhbrm);
		NumberPair numberPair6 = default(NumberPair);
		NumberPair numberPair7 = default(NumberPair);
		double x3 = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num16 = 0.0;
		double num17 = 0.0;
		double num18 = 0.0;
		double num19 = 0.0;
		NumberPair numberPair8 = default(NumberPair);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 1023;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 52;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			numberPair.Lo = 0.0;
			numberPair.Hi = 0.0;
			Llvm_lifetime_start_p0.Invoke(2L, &num4);
			num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			if ((ushort)num4 >= 1023)
			{
				if (Details_expects_bool_condition_bool.Invoke((ulong)num3 >= 5066549580791808000uL, Expected: false))
				{
					long num20 = num3;
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb.Val);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
					bool num21 = Details_expects_bool_condition_bool.Invoke((ulong)num20 > (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)), Expected: false);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					if (num21)
					{
						if (num3 == -4616189618054758400L)
						{
							Fputil_set_errno_if_required.Invoke(34);
							Fputil_raise_except_if_required.Invoke(4);
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_NEG.Pointer, 1L, isVolatile: false);
							long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb2.Val);
							fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
							result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						}
						else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) && !FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
						{
							Fputil_set_errno_if_required.Invoke(33);
							Fputil_raise_except_if_required.Invoke(1);
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
							long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb3.Val, 0L);
							fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val3;
							result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						}
						else
						{
							result = X;
						}
						goto IL_1012;
					}
					numberPair.Hi = X;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
					Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(X, 1.0);
					NumberPair* num22 = &numberPair2;
					Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
					*(double*)num22 = struct_4ydhja2.field_0;
					byte* num23 = (byte*)(&numberPair2) + 8u;
					Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
					*(double*)num23 = struct_4ydhja3.field_1;
					Llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair2, 16L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
				}
			}
			else
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) < 970, Expected: false))
				{
					if (X == 0.0)
					{
						result = X + X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = 1f;
						Llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = -1f;
						Llvm_lifetime_start_p0.Invoke(1L, &b);
						b = (NumericHelper.IsUnorderedOrNotEquals(num5 - 2.9802322E-08f, num5) ? ((sbyte)1) : ((sbyte)0));
						Llvm_lifetime_start_p0.Invoke(1L, &b2);
						b2 = (NumericHelper.IsUnorderedOrNotEquals(num6 - 5.9604645E-08f, num6) ? ((sbyte)1) : ((sbyte)0));
						if (X > 0.0 && (b & 1) == 1)
						{
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
							FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm5, num3 - 1L);
							result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						}
						else if (X < 0.0 && (b2 & 1) == 1)
						{
							Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm6, num3 + 1L);
							result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
							Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						}
						else
						{
							result = ((X + X != 0.0) ? X : (X + X));
						}
						Llvm_lifetime_end_p0.Invoke(1L, &b2);
						Llvm_lifetime_end_p0.Invoke(1L, &b);
						Llvm_lifetime_end_p0.Invoke(4L, &num6);
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
					}
					goto IL_1012;
				}
				Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
				Struct_4ydhja struct_4ydhja4 = Fputil_exact_add_true.Invoke(1.0, X);
				NumberPair* num24 = &numberPair3;
				Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
				*(double*)num24 = struct_4ydhja5.field_0;
				byte* num25 = (byte*)(&numberPair3) + 8u;
				Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
				*(double*)num25 = struct_4ydhja6.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair3, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			}
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			*(long*)(&fputil_FPBits_wjhbrm7) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm7, numberPair.Hi);
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7));
			num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7));
			Llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = (int)(num7 + 17592186044416L >>> 45);
			Llvm_lifetime_start_p0.Invoke(4L, &num9);
		}
		num9 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke(unchecked((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7))) + (num8 >> 7);
		Llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = num9;
		Llvm_lifetime_start_p0.Invoke(8L, &num11);
		double x4 = num10;
		long num26 = num8;
		unchecked
		{
			num11 = Fputil_multiply_add_double.Invoke(x4, 0.6931471805598903, ((NumberPair*)Anonymous_namespace_LOG_R1_DD.Pointer)[num26].Hi);
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			double x5 = num10;
			long num27 = num8;
			num12 = Fputil_multiply_add_double.Invoke(x5, 5.497923018708371E-14, ((NumberPair*)Anonymous_namespace_LOG_R1_DD.Pointer)[num27].Lo);
			Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
			*(double*)(&inlineArray2_Double) = 2.5849394142282115E-26;
			((double*)(&inlineArray2_Double))[1] = 0.0;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, ((num11 == 0.0) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = checked((num3 & 0x7FF0000000000000L) - 4607182418800017408L);
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
			long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb4.Val);
			fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val4;
			long num28 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm8)) | num7;
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			x = num28;
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm10, numberPair.Lo);
			long val5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm10));
			fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.Val = val5;
			long num29 = ((!(FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm9) > numberPair.Hi * 5.877471754111438E-39)) ? 0L : checked(Cpp_bit_cast_long_double.Invoke(&numberPair.Lo) - num13));
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			x2 = num29;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm11, x2);
			numberPair4.Lo = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm11);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm12, x);
			numberPair4.Hi = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm12);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			long num30 = num8;
			num14 = ((double*)Anonymous_namespace_R1.Pointer)[num30];
			Llvm_lifetime_start_p0.Invoke(8L, &a);
			a = double.NaN;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_exact_mult_27ul.Invoke(numberPair4.Lo, num14);
			NumberPair* num31 = &numberPair5;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num31 = struct_4ydhja8.field_0;
			byte* num32 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num32 = struct_4ydhja9.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num15);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm13);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm13, ((long)num8 << 45) + 4607182418800017408L);
			double num33 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm13);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm13);
			num15 = num33;
			double x6 = num14;
			double y = numberPair4.Hi - num15;
			long num34 = num8;
			a = Fputil_multiply_add_double.Invoke(x6, y, ((double*)Anonymous_namespace_RCM1.Pointer)[num34]);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja10 = Fputil_exact_add_true.Invoke(a, numberPair5.Hi);
			NumberPair* num35 = &numberPair6;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num35 = struct_4ydhja11.field_0;
			byte* num36 = (byte*)(&numberPair6) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num36 = struct_4ydhja12.field_1;
			double lo = numberPair5.Lo;
			numberPair6.Lo += lo;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja13 = Fputil_exact_add_true.Invoke(num11, numberPair6.Hi);
			NumberPair* num37 = &numberPair7;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num37 = struct_4ydhja14.field_0;
			byte* num38 = (byte*)(&numberPair7) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num38 = struct_4ydhja15.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = numberPair6.Hi * numberPair6.Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(numberPair6.Hi, ((double*)Anonymous_namespace_P_COEFFS.Pointer)[1], *(double*)Anonymous_namespace_P_COEFFS.Pointer);
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(numberPair6.Hi, ((double*)Anonymous_namespace_P_COEFFS.Pointer)[3L], ((double*)Anonymous_namespace_P_COEFFS.Pointer)[2L]);
			Llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = Fputil_multiply_add_double.Invoke(numberPair6.Hi, ((double*)Anonymous_namespace_P_COEFFS.Pointer)[5L], ((double*)Anonymous_namespace_P_COEFFS.Pointer)[4L]);
			Llvm_lifetime_start_p0.Invoke(8L, &num16);
			num16 = Fputil_polyeval_double_double_double_double.Invoke(x3, numberPair6.Lo + numberPair7.Lo + num12, a_yc74sk, a_ijazrn, a_889uw);
			Llvm_lifetime_start_p0.Invoke(8L, &num17);
			num17 = Fputil_multiply_add_double.Invoke(x3, 1.7763568394002505E-15, z);
			Llvm_lifetime_start_p0.Invoke(8L, &num18);
			num18 = numberPair7.Hi + (num16 - num17);
			Llvm_lifetime_start_p0.Invoke(8L, &num19);
			num19 = numberPair7.Hi + (num16 + num17);
			if (num18 == num19)
			{
				result = num18;
			}
			else
			{
				int e_x = num9;
				int index = num8;
				Llvm_memcpy_p0_p0_i64.Invoke(&numberPair8, &numberPair6, 16L, isVolatile: false);
				result = Anonymous_namespace_log1p_accurate.Invoke(e_x, index, *(double*)(&numberPair8), ((double*)(&numberPair8))[1]);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num19);
			Llvm_lifetime_end_p0.Invoke(8L, &num18);
			Llvm_lifetime_end_p0.Invoke(8L, &num17);
			Llvm_lifetime_end_p0.Invoke(8L, &num16);
			Llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &x3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			Llvm_lifetime_end_p0.Invoke(8L, &num15);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num13);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(4L, &num9);
			Llvm_lifetime_end_p0.Invoke(4L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			goto IL_1012;
		}
		IL_1012:
		Llvm_lifetime_end_p0.Invoke(2L, &num4);
		Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
