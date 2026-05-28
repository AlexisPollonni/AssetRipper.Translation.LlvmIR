using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cos
{
	[MangledName("cos")]
	[DemangledName("cos")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		short num = 0;
		NumberPair numberPair = default(NumberPair);
		int num2 = 0;
		LargeRangeReduction largeRangeReduction = default(LargeRangeReduction);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
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
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd2 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd3 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd4 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(Fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd6 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd7 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd8 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd9 = default(Fputil_DyadicFloat_kt2kd4);
		Fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd10 = default(Fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		double result;
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
						result = ((!Details_expects_bool_condition_bool.Invoke(X == 0.0, Expected: false)) ? Fputil_round_result_slightly_down_double.Invoke(1.0) : 1.0);
						goto IL_0b55;
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
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb.Val, 0L);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
					result = X + FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					goto IL_0b55;
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
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = Generic_sincos_eval.Invoke(&numberPair, &numberPair2, &numberPair3);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			long num8 = (uint)((num2 + 128) & 0xFF);
			Llvm_memcpy_p0_p0_i64.Invoke(&numberPair4, (byte*)SIN_K_PI_OVER_128.Pointer + (nint)num8 * sizeof(NumberPair), 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			long num9 = (uint)((num2 + 64) & 0xFF);
			Llvm_memcpy_p0_p0_i64.Invoke(&numberPair5, (byte*)SIN_K_PI_OVER_128.Pointer + (nint)num9 * sizeof(NumberPair), 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = double.NaN;
			((double*)(&numberPair6))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(&numberPair3, &numberPair5);
			NumberPair* num10 = &numberPair6;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num10 = struct_4ydhja2.field_0;
			byte* num11 = (byte*)(&numberPair6) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num11 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = double.NaN;
			((double*)(&numberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_quick_mult_27ul.Invoke(&numberPair2, &numberPair4);
			NumberPair* num12 = &numberPair7;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num12 = struct_4ydhja5.field_0;
			byte* num13 = (byte*)(&numberPair7) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num13 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair8);
			*(double*)(&numberPair8) = double.NaN;
			((double*)(&numberPair8))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_exact_add_false.Invoke(numberPair6.Hi, numberPair7.Hi);
			NumberPair* num14 = &numberPair8;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num14 = struct_4ydhja8.field_0;
			byte* num15 = (byte*)(&numberPair8) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num15 = struct_4ydhja9.field_1;
			double num16 = numberPair7.Lo + numberPair6.Lo;
			numberPair8.Lo += num16;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = numberPair8.Lo + num3;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = numberPair8.Lo - num3;
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = numberPair8.Hi + num4;
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = numberPair8.Hi + num5;
			if (Details_expects_bool_condition_bool.Invoke(num6 == num7, Expected: true))
			{
				result = num6;
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
					Range_reduction_small_f128_nv2a7v.Invoke(&fputil_DyadicFloat_kt2kd4, X);
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
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
				*(sbyte*)(&anon_izyfb2) = -86;
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
				_0_Invoke_zdjgbv.Invoke(&fputil_DyadicFloat_kt2kd6, &anon_izyfb2, num2 + 128);
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
				_0_Invoke_zdjgbv.Invoke(&fputil_DyadicFloat_kt2kd7, &anon_izyfb2, num2 + 64);
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
				Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd7, &fputil_DyadicFloat_kt2kd3);
				Fputil_quick_mul_128ul.Invoke(&fputil_DyadicFloat_kt2kd10, &fputil_DyadicFloat_kt2kd6, &fputil_DyadicFloat_kt2kd2);
				Fputil_quick_add_128ul.Invoke(&fputil_DyadicFloat_kt2kd8, &fputil_DyadicFloat_kt2kd9, &fputil_DyadicFloat_kt2kd10);
				result = DyadicFloat_128ul_Double_double_void.Invoke(&fputil_DyadicFloat_kt2kd8);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd8);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd7);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd6);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd2);
				Llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair8);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			goto IL_0b55;
		}
		IL_0b55:
		Llvm_lifetime_end_p0.Invoke(48L, &largeRangeReduction);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		return result;
	}
}
