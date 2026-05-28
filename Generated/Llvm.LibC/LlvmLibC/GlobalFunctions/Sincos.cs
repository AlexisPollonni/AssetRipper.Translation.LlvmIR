using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sincos
{
	[MangledName("sincos")]
	[DemangledName("sincos")]
	public unsafe static void Invoke([MangledName("x")] double X, [MangledName("sin_x")] void* Sin_x, [MangledName("cos_x")] void* Cos_x)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		short num = 0;
		NumberPair numberPair = default(NumberPair);
		int num2 = 0;
		LargeRangeReduction largeRangeReduction = default(LargeRangeReduction);
		int num3 = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
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
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd3 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd4 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(Fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd11 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd12 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd13 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd14 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		int num13;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1431655766;
			Llvm_lifetime_start_p0.Invoke(48L, &largeRangeReduction);
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
			Llvm_memset_p0_i64.Invoke(&largeRangeReduction, 0, 48L, isVolatile: false);
			LargeRangeReduction_Constructor.Invoke(&largeRangeReduction);
			if (Details_expects_bool_condition_bool.Invoke((ushort)num < 1039, Expected: true))
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)num < 1016, Expected: false))
				{
					if (Details_expects_bool_condition_bool.Invoke((ushort)num < 996, Expected: false))
					{
						if (Details_expects_bool_condition_bool.Invoke(X == 0.0, Expected: false))
						{
							*(double*)Sin_x = X;
							*(double*)Cos_x = 1.0;
							num13 = 1;
							goto IL_109e;
						}
						*(double*)Cos_x = Fputil_round_result_slightly_down_double.Invoke(1.0);
						if (!Details_expects_bool_condition_bool.Invoke((ushort)num < 4, Expected: false))
						{
							goto IL_048d;
						}
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = Fputil_quick_get_round.Invoke();
						if (num3 != 3072)
						{
							anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
							if (!Equals_fy8fvt.Invoke(anon_izyfb.Val, anon_izyfb2.Val) || num3 != 1024)
							{
								anon_izyfb3.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_NEG.Pointer, 1L, isVolatile: false);
								if (!Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val) || num3 != 2048)
								{
									goto IL_047b;
								}
							}
						}
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) - 1L);
						*(double*)Sin_x = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						goto IL_047b;
					}
					num2 = 0;
					numberPair.Lo = 0.0;
					numberPair.Hi = X;
				}
				else
				{
					num2 = Range_reduction_small.Invoke(X, &numberPair);
				}
			}
			else
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)num > 2046, Expected: false))
				{
					if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) == 0L)
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb5.Val, 0L);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val;
					*(double*)Sin_x = (*(double*)Cos_x = X + FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3));
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					num13 = 1;
					goto IL_109e;
				}
				num2 = LargeRangeReduction_fast.Invoke(&largeRangeReduction, X, &numberPair);
			}
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair2);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair3);
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = Generic_sincos_eval.Invoke(&numberPair, &numberPair2, &numberPair3);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			long num14 = (uint)(num2 & 0xFF);
			Llvm_memcpy_p0_p0_i64.Invoke(&numberPair4, (byte*)SIN_K_PI_OVER_128.Pointer + (nint)num14 * sizeof(NumberPair), 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			long num15 = (uint)((num2 + 64) & 0xFF);
			Llvm_memcpy_p0_p0_i64.Invoke(&numberPair5, (byte*)SIN_K_PI_OVER_128.Pointer + (nint)num15 * sizeof(NumberPair), 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			numberPair6.Lo = 0.0 - numberPair4.Lo;
			numberPair6.Hi = 0.0 - numberPair4.Hi;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(&numberPair3, &numberPair4);
			NumberPair* num16 = &numberPair7;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num16 = struct_4ydhja2.field_0;
			byte* num17 = (byte*)(&numberPair7) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num17 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair8);
			*(double*)(&numberPair8) = double.NaN;
			((double*)(&numberPair8))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_quick_mult_27ul.Invoke(&numberPair2, &numberPair5);
			NumberPair* num18 = &numberPair8;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num18 = struct_4ydhja5.field_0;
			byte* num19 = (byte*)(&numberPair8) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num19 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair9);
			*(double*)(&numberPair9) = double.NaN;
			((double*)(&numberPair9))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_quick_mult_27ul.Invoke(&numberPair3, &numberPair5);
			NumberPair* num20 = &numberPair9;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num20 = struct_4ydhja8.field_0;
			byte* num21 = (byte*)(&numberPair9) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num21 = struct_4ydhja9.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair10);
			*(double*)(&numberPair10) = double.NaN;
			((double*)(&numberPair10))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja10 = Fputil_quick_mult_27ul.Invoke(&numberPair2, &numberPair6);
			NumberPair* num22 = &numberPair10;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num22 = struct_4ydhja11.field_0;
			byte* num23 = (byte*)(&numberPair10) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num23 = struct_4ydhja12.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair11);
			*(double*)(&numberPair11) = double.NaN;
			((double*)(&numberPair11))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja13 = Fputil_exact_add_false.Invoke(numberPair7.Hi, numberPair8.Hi);
			NumberPair* num24 = &numberPair11;
			Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
			*(double*)num24 = struct_4ydhja14.field_0;
			byte* num25 = (byte*)(&numberPair11) + 8u;
			Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
			*(double*)num25 = struct_4ydhja15.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair12);
			*(double*)(&numberPair12) = double.NaN;
			((double*)(&numberPair12))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja16 = Fputil_exact_add_false.Invoke(numberPair9.Hi, numberPair10.Hi);
			NumberPair* num26 = &numberPair12;
			Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
			*(double*)num26 = struct_4ydhja17.field_0;
			byte* num27 = (byte*)(&numberPair12) + 8u;
			Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
			*(double*)num27 = struct_4ydhja18.field_1;
			double num28 = numberPair7.Lo + numberPair8.Lo;
			numberPair11.Lo += num28;
			double num29 = numberPair10.Lo + numberPair9.Lo;
			numberPair12.Lo += num29;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = numberPair11.Lo + num4;
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = numberPair11.Lo - num4;
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = numberPair12.Lo + num4;
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = numberPair12.Lo - num4;
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = numberPair11.Hi + num5;
			Llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = numberPair11.Hi + num6;
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = numberPair12.Hi + num7;
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = numberPair12.Hi + num8;
			if (Details_expects_bool_condition_bool.Invoke(num9 == num10 && num11 == num12, Expected: true))
			{
				*(double*)Sin_x = num9;
				*(double*)Cos_x = num11;
				num13 = 1;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd) = -86;
				sbyte* ptr3 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 1;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd))[1] = -1431655766;
				sbyte* ptr4 = (sbyte*)(&fputil_DyadicFloat_kt2kd) + 8;
				*(long*)ptr4 = -6148914691236517206L;
				((long*)ptr4)[1] = -6148914691236517206L;
				DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd);
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd2) = -86;
				sbyte* ptr5 = (sbyte*)(&fputil_DyadicFloat_kt2kd2) + 1;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd2))[1] = -1431655766;
				sbyte* ptr6 = (sbyte*)(&fputil_DyadicFloat_kt2kd2) + 8;
				*(long*)ptr6 = -6148914691236517206L;
				((long*)ptr6)[1] = -6148914691236517206L;
				DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd2);
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd3) = -86;
				sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd3) + 1;
				*ptr7 = -86;
				ptr7[1] = -86;
				ptr7[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd3))[1] = -1431655766;
				sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd3) + 8;
				*(long*)ptr8 = -6148914691236517206L;
				((long*)ptr8)[1] = -6148914691236517206L;
				DyadicFloat_128ul_Constructor.Invoke(&fputil_DyadicFloat_kt2kd3);
				if (Details_expects_bool_condition_bool.Invoke((ushort)num < 1039, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd4);
					Range_reduction_small_f128_gx4qkc.Invoke(&fputil_DyadicFloat_kt2kd4, X);
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd, &fputil_DyadicFloat_kt2kd4, 24L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
					LargeRangeReduction_accurate.Invoke(&fputil_DyadicFloat_kt2kd5, &largeRangeReduction);
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_kt2kd, &fputil_DyadicFloat_kt2kd5, 24L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
				}
				Generic_sincos_eval.Invoke(&fputil_DyadicFloat_kt2kd, &fputil_DyadicFloat_kt2kd2, &fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb6);
				*(sbyte*)(&anon_izyfb6) = -86;
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd6) = -86;
				sbyte* ptr9 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 1;
				*ptr9 = -86;
				ptr9[1] = -86;
				ptr9[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
				sbyte* ptr10 = (sbyte*)(&fputil_DyadicFloat_kt2kd6) + 8;
				*(long*)ptr10 = -6148914691236517206L;
				((long*)ptr10)[1] = -6148914691236517206L;
				_0_Invoke_h7rrab.Invoke(&fputil_DyadicFloat_kt2kd6, &anon_izyfb6, num2);
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd7) = -86;
				sbyte* ptr11 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 1;
				*ptr11 = -86;
				ptr11[1] = -86;
				ptr11[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
				sbyte* ptr12 = (sbyte*)(&fputil_DyadicFloat_kt2kd7) + 8;
				*(long*)ptr12 = -6148914691236517206L;
				((long*)ptr12)[1] = -6148914691236517206L;
				_0_Invoke_h7rrab.Invoke(&fputil_DyadicFloat_kt2kd7, &anon_izyfb6, num2 + 64);
				Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
				*(sbyte*)(&fputil_DyadicFloat_kt2kd8) = -86;
				sbyte* ptr13 = (sbyte*)(&fputil_DyadicFloat_kt2kd8) + 1;
				*ptr13 = -86;
				ptr13[1] = -86;
				ptr13[2] = -86;
				((int*)(&fputil_DyadicFloat_kt2kd8))[1] = -1431655766;
				sbyte* ptr14 = (sbyte*)(&fputil_DyadicFloat_kt2kd8) + 8;
				*(long*)ptr14 = -6148914691236517206L;
				((long*)ptr14)[1] = -6148914691236517206L;
				_0_Invoke_h7rrab.Invoke(&fputil_DyadicFloat_kt2kd8, &anon_izyfb6, num2 + 128);
				if (num9 == num10)
				{
					*(double*)Sin_x = num9;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd9);
					Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd3);
					Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd11, &fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd2);
					Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd11);
					*(double*)Sin_x = DyadicFloat_128ul_Double_double_void.Invoke(&fputil_DyadicFloat_kt2kd9);
					Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd9);
				}
				if (num11 == num12)
				{
					*(double*)Cos_x = num11;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
					Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd3);
					Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd14, &fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd2);
					Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd12, &fputil_DyadicFloat_kt2kd13, &fputil_DyadicFloat_kt2kd14);
					*(double*)Cos_x = DyadicFloat_128ul_Double_double_void.Invoke(&fputil_DyadicFloat_kt2kd12);
					Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd12);
				}
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb6);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
				num13 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair12);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair11);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair10);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair9);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair8);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			goto IL_109e;
		}
		IL_109e:
		Llvm_lifetime_end_p0.Invoke(48L, &largeRangeReduction);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		switch (num13)
		{
		case 0:
		case 1:
			return;
		}
		throw new NotImplementedException("Reached LLVM unreachable instruction.");
		IL_047b:
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_048d;
		IL_048d:
		*unchecked((double*)Sin_x) = Fputil_multiply_add_double.Invoke(X, -5.551115123125783E-17, X);
		num13 = 1;
		goto IL_109e;
	}
}
