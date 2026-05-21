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
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num3 = 0L;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		short num4 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		float num5 = 0f;
		float num6 = 0f;
		sbyte b = 0;
		sbyte b2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm6 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm7 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
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
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm8 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		long x2 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm9 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm10 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm11 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm12 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double num14 = 0.0;
		double a = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair5 = default(Llvm_libc_20_1_2_NumberPair);
		double num15 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm13 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair6 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair7 = default(Llvm_libc_20_1_2_NumberPair);
		double x3 = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num16 = 0.0;
		double num17 = 0.0;
		double num18 = 0.0;
		double num19 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair8 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 1023;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 52;
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double result;
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			llvm_libc_20_1_2_NumberPair.Lo = 0.0;
			llvm_libc_20_1_2_NumberPair.Hi = 0.0;
			Llvm_lifetime_start_p0.Invoke(2L, &num4);
			num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			if ((ushort)num4 >= 1023)
			{
				if (Details_expects_bool_condition_bool.Invoke((ulong)num3 >= 5066549580791808000uL, Expected: false))
				{
					long num20 = num3;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
					bool num21 = Details_expects_bool_condition_bool.Invoke((ulong)num20 > (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)), Expected: false);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					if (num21)
					{
						if (num3 == -4616189618054758400L)
						{
							Fputil_set_errno_if_required.Invoke(34);
							Fputil_raise_except_if_required.Invoke(4);
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
							long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb2.Val);
							llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
							result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
						}
						else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) && !FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
						{
							Fputil_set_errno_if_required.Invoke(33);
							Fputil_raise_except_if_required.Invoke(1);
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb3.Val, 0L);
							llvm_libc_20_1_2_fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val3;
							result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
						}
						else
						{
							result = X;
						}
						goto IL_1012;
					}
					llvm_libc_20_1_2_NumberPair.Hi = X;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
					Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(X, 1.0);
					Llvm_libc_20_1_2_NumberPair* num22 = &llvm_libc_20_1_2_NumberPair2;
					Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
					*(double*)num22 = struct_4ydhja2.field_0;
					byte* num23 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
					Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
					*(double*)num23 = struct_4ydhja3.field_1;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair2, 16L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
				}
			}
			else
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) < 970, Expected: false))
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
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
							FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5, num3 - 1L);
							result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
						}
						else if (X < 0.0 && (b2 & 1) == 1)
						{
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
							FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6, num3 + 1L);
							result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
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
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
				Struct_4ydhja struct_4ydhja4 = Fputil_exact_add_true.Invoke(1.0, X);
				Llvm_libc_20_1_2_NumberPair* num24 = &llvm_libc_20_1_2_NumberPair3;
				Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
				*(double*)num24 = struct_4ydhja5.field_0;
				byte* num25 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
				Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
				*(double*)num25 = struct_4ydhja6.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair3, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			}
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, llvm_libc_20_1_2_NumberPair.Hi);
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7));
			num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7));
			Llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = (int)(num7 + 17592186044416L >>> 45);
			Llvm_lifetime_start_p0.Invoke(4L, &num9);
		}
		num9 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke(unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7))) + (num8 >> 7);
		Llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = num9;
		Llvm_lifetime_start_p0.Invoke(8L, &num11);
		double x4 = num10;
		long num26 = num8;
		unchecked
		{
			num11 = Fputil_multiply_add_double.Invoke(x4, 0.6931471805598903, ((Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_LOG_R1_DD.Pointer)[num26].Hi);
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			double x5 = num10;
			long num27 = num8;
			num12 = Fputil_multiply_add_double.Invoke(x5, 5.497923018708371E-14, ((Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_LOG_R1_DD.Pointer)[num27].Lo);
			Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
			*(double*)(&inlineArray2_Double) = 2.5849394142282115E-26;
			((double*)(&inlineArray2_Double))[1] = 0.0;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, ((num11 == 0.0) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = checked((num3 & 0x7FF0000000000000L) - 4607182418800017408L);
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb4.Val);
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val4;
			long num28 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8)) | num7;
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
			x = num28;
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm10, llvm_libc_20_1_2_NumberPair.Lo);
			long val5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm10));
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.Val = val5;
			long num29 = ((!(FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9) > llvm_libc_20_1_2_NumberPair.Hi * 5.877471754111438E-39)) ? 0L : checked(Cpp_bit_cast_long_double.Invoke(&llvm_libc_20_1_2_NumberPair.Lo) - num13));
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
			x2 = num29;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm11, x2);
			llvm_libc_20_1_2_NumberPair4.Lo = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm12);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm12, x);
			llvm_libc_20_1_2_NumberPair4.Hi = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm12);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm12);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			long num30 = num8;
			num14 = ((double*)Llvm_libc_20_1_2_anonymous_namespace_R1.Pointer)[num30];
			Llvm_lifetime_start_p0.Invoke(8L, &a);
			a = double.NaN;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			*(double*)(&llvm_libc_20_1_2_NumberPair5) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair5))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_exact_mult_27ul.Invoke(llvm_libc_20_1_2_NumberPair4.Lo, num14);
			Llvm_libc_20_1_2_NumberPair* num31 = &llvm_libc_20_1_2_NumberPair5;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num31 = struct_4ydhja8.field_0;
			byte* num32 = (byte*)(&llvm_libc_20_1_2_NumberPair5) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num32 = struct_4ydhja9.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num15);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm13);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm13, ((long)num8 << 45) + 4607182418800017408L);
			double num33 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm13);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm13);
			num15 = num33;
			double x6 = num14;
			double y = llvm_libc_20_1_2_NumberPair4.Hi - num15;
			long num34 = num8;
			a = Fputil_multiply_add_double.Invoke(x6, y, ((double*)Llvm_libc_20_1_2_anonymous_namespace_RCM1.Pointer)[num34]);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
			*(double*)(&llvm_libc_20_1_2_NumberPair6) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair6))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja10 = Fputil_exact_add_true.Invoke(a, llvm_libc_20_1_2_NumberPair5.Hi);
			Llvm_libc_20_1_2_NumberPair* num35 = &llvm_libc_20_1_2_NumberPair6;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num35 = struct_4ydhja11.field_0;
			byte* num36 = (byte*)(&llvm_libc_20_1_2_NumberPair6) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num36 = struct_4ydhja12.field_1;
			double lo = llvm_libc_20_1_2_NumberPair5.Lo;
			llvm_libc_20_1_2_NumberPair6.Lo += lo;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
			*(double*)(&llvm_libc_20_1_2_NumberPair7) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja13 = Fputil_exact_add_true.Invoke(num11, llvm_libc_20_1_2_NumberPair6.Hi);
			Llvm_libc_20_1_2_NumberPair* num37 = &llvm_libc_20_1_2_NumberPair7;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num37 = struct_4ydhja14.field_0;
			byte* num38 = (byte*)(&llvm_libc_20_1_2_NumberPair7) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num38 = struct_4ydhja15.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = llvm_libc_20_1_2_NumberPair6.Hi * llvm_libc_20_1_2_NumberPair6.Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair6.Hi, ((double*)Llvm_libc_20_1_2_anonymous_namespace_P_COEFFS.Pointer)[1], *(double*)Llvm_libc_20_1_2_anonymous_namespace_P_COEFFS.Pointer);
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair6.Hi, ((double*)Llvm_libc_20_1_2_anonymous_namespace_P_COEFFS.Pointer)[3L], ((double*)Llvm_libc_20_1_2_anonymous_namespace_P_COEFFS.Pointer)[2L]);
			Llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = Fputil_multiply_add_double.Invoke(llvm_libc_20_1_2_NumberPair6.Hi, ((double*)Llvm_libc_20_1_2_anonymous_namespace_P_COEFFS.Pointer)[5L], ((double*)Llvm_libc_20_1_2_anonymous_namespace_P_COEFFS.Pointer)[4L]);
			Llvm_lifetime_start_p0.Invoke(8L, &num16);
			num16 = Fputil_polyeval_double_double_double_double.Invoke(x3, llvm_libc_20_1_2_NumberPair6.Lo + llvm_libc_20_1_2_NumberPair7.Lo + num12, a_yc74sk, a_ijazrn, a_889uw);
			Llvm_lifetime_start_p0.Invoke(8L, &num17);
			num17 = Fputil_multiply_add_double.Invoke(x3, 1.7763568394002505E-15, z);
			Llvm_lifetime_start_p0.Invoke(8L, &num18);
			num18 = llvm_libc_20_1_2_NumberPair7.Hi + (num16 - num17);
			Llvm_lifetime_start_p0.Invoke(8L, &num19);
			num19 = llvm_libc_20_1_2_NumberPair7.Hi + (num16 + num17);
			if (num18 == num19)
			{
				result = num18;
			}
			else
			{
				int e_x = num9;
				int index = num8;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair8, &llvm_libc_20_1_2_NumberPair6, 16L, isVolatile: false);
				result = Anonymous_namespace_log1p_accurate.Invoke(e_x, index, *(double*)(&llvm_libc_20_1_2_NumberPair8), ((double*)(&llvm_libc_20_1_2_NumberPair8))[1]);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num19);
			Llvm_lifetime_end_p0.Invoke(8L, &num18);
			Llvm_lifetime_end_p0.Invoke(8L, &num17);
			Llvm_lifetime_end_p0.Invoke(8L, &num16);
			Llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &x3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
			Llvm_lifetime_end_p0.Invoke(8L, &num15);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
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
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
			goto IL_1012;
		}
		IL_1012:
		Llvm_lifetime_end_p0.Invoke(2L, &num4);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
