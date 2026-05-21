using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class atan2
{
	public unsafe static double Invoke(double y, double x)
	{
		double result = 0.0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		NumberPair numberPair4 = default(NumberPair);
		NumberPair numberPair5 = default(NumberPair);
		NumberPair numberPair6 = default(NumberPair);
		NumberPair numberPair7 = default(NumberPair);
		NumberPair numberPair8 = default(NumberPair);
		InlineArray2_InlineArray2_InlineArray2_NumberPair inlineArray2_InlineArray2_InlineArray2_NumberPair = default(InlineArray2_InlineArray2_InlineArray2_NumberPair);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		sbyte b2 = 0;
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		long num2 = 0L;
		sbyte b3 = 0;
		long num3 = 0L;
		long num4 = 0L;
		int num5 = 0;
		int num6 = 0;
		double num7 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		double num8 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		int num9 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		int num10 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		InlineArray3_InlineArray3_InlineArray2_NumberPair inlineArray3_InlineArray3_InlineArray2_NumberPair = default(InlineArray3_InlineArray3_InlineArray2_NumberPair);
		NumberPair numberPair9 = default(NumberPair);
		sbyte b4 = 0;
		sbyte b5 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm12 = default(fputil_FPBits_wjhbrm);
		double num11 = 0.0;
		NumberPair numberPair10 = default(NumberPair);
		int num12 = 0;
		double num13 = 0.0;
		int num14 = 0;
		NumberPair numberPair11 = default(NumberPair);
		NumberPair numberPair12 = default(NumberPair);
		NumberPair numberPair13 = default(NumberPair);
		NumberPair numberPair14 = default(NumberPair);
		NumberPair numberPair15 = default(NumberPair);
		NumberPair numberPair16 = default(NumberPair);
		NumberPair numberPair17 = default(NumberPair);
		NumberPair numberPair18 = default(NumberPair);
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
		unchecked
		{
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			llvm_memset_p0_i64.Invoke(&numberPair, 0, 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = -0.0;
			((double*)(&numberPair2))[1] = -0.0;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = 1.2246467991473532E-16;
			((double*)(&numberPair3))[1] = Math.PI;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = -1.2246467991473532E-16;
			((double*)(&numberPair4))[1] = -Math.PI;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = 6.123233995736766E-17;
			((double*)(&numberPair5))[1] = Math.PI / 2.0;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair6);
			*(double*)(&numberPair6) = -6.123233995736766E-17;
			((double*)(&numberPair6))[1] = -Math.PI / 2.0;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair7);
			*(double*)(&numberPair7) = 3.061616997868383E-17;
			((double*)(&numberPair7))[1] = Math.PI / 4.0;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair8);
			*(double*)(&numberPair8) = 9.184850993605148E-17;
			((double*)(&numberPair8))[1] = Math.PI * 3.0 / 4.0;
			llvm_lifetime_start_p0.Invoke(128L, &inlineArray2_InlineArray2_InlineArray2_NumberPair);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray2_InlineArray2_InlineArray2_NumberPair, CONST_ADJ_5izt5t.Pointer, 128L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, y);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
			bool num15 = Sign_is_neg.Invoke(&anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			b = (num15 ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
			anon_izyfb9.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm3);
			bool num16 = Sign_is_neg.Invoke(&anon_izyfb9);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
			b2 = (num16 ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm4, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val2;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm3, &fputil_FPBits_wjhbrm5, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (((ulong)num < (ulong)num2) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = (((b3 & 1) != 1) ? num2 : num);
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = (((b3 & 1) == 1) ? num2 : num);
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = (int)(num3 >>> 52);
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = (int)(num4 >>> 52);
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm6, num3);
			double num17 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
			num7 = num17;
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm7, num4);
			double num18 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm7);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			num8 = num18;
			if (details_expects_bool_condition_bool.Invoke(((uint)num6 <= 1919u) ? ((uint)num5 < 128u) : true, expected: false))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm3)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb10.val, 0L);
					fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val3;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					goto IL_0fd6;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num9);
				bool num19 = x == 0.0;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				int num20;
				if (num19)
				{
					num20 = 0;
				}
				else
				{
					FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm9, num);
					num20 = InstructionHelper.Select(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm9)), 2, 1);
				}
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				num9 = num20;
				llvm_lifetime_start_p0.Invoke(4L, &num10);
				bool num21 = y == 0.0;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
				int num22;
				if (num21)
				{
					num22 = 0;
				}
				else
				{
					FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm10, num2);
					num22 = InstructionHelper.Select(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm10)), 2, 1);
				}
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
				num10 = num22;
				llvm_lifetime_start_p0.Invoke(288L, &inlineArray3_InlineArray3_InlineArray2_NumberPair);
				llvm_memcpy_p0_p0_i64.Invoke(&inlineArray3_InlineArray3_InlineArray2_NumberPair, EXCEPTS_t7bjdm.Pointer, 288L, isVolatile: false);
				int num23;
				if (num9 != 1 || num10 != 1)
				{
					llvm_lifetime_start_p0.Invoke(16L, &numberPair9);
					*(double*)(&numberPair9) = double.NaN;
					((double*)(&numberPair9))[1] = double.NaN;
					llvm_memcpy_p0_p0_i64.Invoke(&numberPair9, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref inlineArray3_InlineArray3_InlineArray2_NumberPair, (nint)(uint)num10 * (nint)sizeof(InlineArray3_InlineArray2_NumberPair)), (nint)(uint)num9 * (nint)sizeof(InlineArray2_NumberPair)), (((b & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(NumberPair))), 16L, isVolatile: false);
					result = fputil_multiply_add_double.Invoke(Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (((b2 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double))), numberPair9.hi, Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (((b2 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double))) * numberPair9.lo);
					num23 = 1;
					llvm_lifetime_end_p0.Invoke(16L, &numberPair9);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(1L, &b4);
					b4 = (((uint)num5 < 128u) ? ((sbyte)1) : ((sbyte)0));
					llvm_lifetime_start_p0.Invoke(1L, &b5);
					b5 = (((uint)num6 > 1919u) ? ((sbyte)1) : ((sbyte)0));
					if ((b4 & 1) == 1)
					{
						num7 *= 1.8446744073709552E+19;
						if ((b5 & 1) != 1)
						{
							num8 *= 1.8446744073709552E+19;
						}
					}
					else if ((b5 & 1) == 1)
					{
						num8 *= 5.421010862427522E-20;
						if ((b4 & 1) != 1)
						{
							num7 *= 5.421010862427522E-20;
						}
					}
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
					FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm11, num7);
					num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm11));
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
					FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm12, num8);
					num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm12));
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
					num5 = (int)(num3 >>> 52);
					num6 = (int)(num4 >>> 52);
					llvm_lifetime_end_p0.Invoke(1L, &b5);
					llvm_lifetime_end_p0.Invoke(1L, &b4);
					num23 = 0;
				}
				llvm_lifetime_end_p0.Invoke(288L, &inlineArray3_InlineArray3_InlineArray2_NumberPair);
				llvm_lifetime_end_p0.Invoke(4L, &num10);
				llvm_lifetime_end_p0.Invoke(4L, &num9);
				switch (num23)
				{
				case 0:
					break;
				default:
					goto IL_0fd6;
				}
			}
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (((b & 1) == 1 != ((b2 & 1) == 1) != ((b3 & 1) == 1)) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
			llvm_lifetime_start_p0.Invoke(16L, &numberPair10);
			*(double*)(&numberPair10) = double.NaN;
			((double*)(&numberPair10))[1] = double.NaN;
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair10, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_InlineArray2_NumberPair, (((b & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(InlineArray2_InlineArray2_NumberPair)), (((b2 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(InlineArray2_NumberPair)), (((b3 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(NumberPair))), 16L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(4L, &num12);
			num12 = num6 - num5;
			if (details_expects_bool_condition_bool.Invoke((uint)num12 > 54u, expected: false))
			{
				result = fputil_multiply_add_double.Invoke(num11, numberPair10.hi, num11 * (numberPair10.lo + num7 / num8));
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num13);
				num13 = fputil_nearest_integer.Invoke(64.0 * num7 / num8);
				llvm_lifetime_start_p0.Invoke(4L, &num14);
				num14 = (int)(uint)num13;
				num13 *= 1.0 / 64.0;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair11);
				*(double*)(&numberPair11) = double.NaN;
				((double*)(&numberPair11))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja = fputil_exact_mult_27ul.Invoke(num7, num13);
				NumberPair* num24 = &numberPair11;
				Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
				*(double*)num24 = struct_4ydhja2.field_0;
				byte* num25 = (byte*)(&numberPair11) + 8u;
				Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
				*(double*)num25 = struct_4ydhja3.field_1;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair12);
				*(double*)(&numberPair12) = double.NaN;
				((double*)(&numberPair12))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja4 = fputil_exact_mult_27ul.Invoke(num8, num13);
				NumberPair* num26 = &numberPair12;
				Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
				*(double*)num26 = struct_4ydhja5.field_0;
				byte* num27 = (byte*)(&numberPair12) + 8u;
				Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
				*(double*)num27 = struct_4ydhja6.field_1;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair13);
				*(double*)(&numberPair13) = double.NaN;
				((double*)(&numberPair13))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja7 = fputil_exact_add_true.Invoke(num7 - numberPair12.hi, 0.0 - numberPair12.lo);
				NumberPair* num28 = &numberPair13;
				Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
				*(double*)num28 = struct_4ydhja8.field_0;
				byte* num29 = (byte*)(&numberPair13) + 8u;
				Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
				*(double*)num29 = struct_4ydhja9.field_1;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair14);
				*(double*)(&numberPair14) = double.NaN;
				((double*)(&numberPair14))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja10 = fputil_exact_add_true.Invoke(num8, numberPair11.hi);
				NumberPair* num30 = &numberPair14;
				Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
				*(double*)num30 = struct_4ydhja11.field_0;
				byte* num31 = (byte*)(&numberPair14) + 8u;
				Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
				*(double*)num31 = struct_4ydhja12.field_1;
				double lo = numberPair11.lo;
				numberPair14.lo += lo;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair15);
				*(double*)(&numberPair15) = double.NaN;
				((double*)(&numberPair15))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja13 = fputil_div.Invoke(&numberPair13, &numberPair14);
				NumberPair* num32 = &numberPair15;
				Struct_4ydhja struct_4ydhja14 = struct_4ydhja13;
				*(double*)num32 = struct_4ydhja14.field_0;
				byte* num33 = (byte*)(&numberPair15) + 8u;
				Struct_4ydhja struct_4ydhja15 = struct_4ydhja13;
				*(double*)num33 = struct_4ydhja15.field_1;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair16);
				*(double*)(&numberPair16) = double.NaN;
				((double*)(&numberPair16))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja16 = anonymous_namespace_atan_eval.Invoke(&numberPair15);
				NumberPair* num34 = &numberPair16;
				Struct_4ydhja struct_4ydhja17 = struct_4ydhja16;
				*(double*)num34 = struct_4ydhja17.field_0;
				byte* num35 = (byte*)(&numberPair16) + 8u;
				Struct_4ydhja struct_4ydhja18 = struct_4ydhja16;
				*(double*)num35 = struct_4ydhja18.field_1;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair17);
				*(double*)(&numberPair17) = double.NaN;
				((double*)(&numberPair17))[1] = double.NaN;
				llvm_lifetime_start_p0.Invoke(16L, &numberPair18);
				long num36 = (uint)num14;
				Struct_4ydhja struct_4ydhja19 = fputil_add.Invoke((NumberPair*)anonymous_namespace_ATAN_I_62.Pointer + num36, &numberPair16);
				NumberPair* num37 = &numberPair18;
				Struct_4ydhja struct_4ydhja20 = struct_4ydhja19;
				*(double*)num37 = struct_4ydhja20.field_0;
				byte* num38 = (byte*)(&numberPair18) + 8u;
				Struct_4ydhja struct_4ydhja21 = struct_4ydhja19;
				*(double*)num38 = struct_4ydhja21.field_1;
				Struct_4ydhja struct_4ydhja22 = fputil_add.Invoke(&numberPair10, &numberPair18);
				NumberPair* num39 = &numberPair17;
				Struct_4ydhja struct_4ydhja23 = struct_4ydhja22;
				*(double*)num39 = struct_4ydhja23.field_0;
				byte* num40 = (byte*)(&numberPair17) + 8u;
				Struct_4ydhja struct_4ydhja24 = struct_4ydhja22;
				*(double*)num40 = struct_4ydhja24.field_1;
				llvm_lifetime_end_p0.Invoke(16L, &numberPair18);
				numberPair17.hi *= num11;
				numberPair17.lo *= num11;
				result = numberPair17.hi + numberPair17.lo;
				llvm_lifetime_end_p0.Invoke(16L, &numberPair17);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair16);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair15);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair14);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair13);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair12);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair11);
				llvm_lifetime_end_p0.Invoke(4L, &num14);
				llvm_lifetime_end_p0.Invoke(8L, &num13);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num12);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair10);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			goto IL_0fd6;
		}
		IL_0fd6:
		llvm_lifetime_end_p0.Invoke(8L, &num8);
		llvm_lifetime_end_p0.Invoke(8L, &num7);
		llvm_lifetime_end_p0.Invoke(4L, &num6);
		llvm_lifetime_end_p0.Invoke(4L, &num5);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(128L, &inlineArray2_InlineArray2_InlineArray2_NumberPair);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair8);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair7);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair6);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
		llvm_lifetime_end_p0.Invoke(16L, &numberPair);
		llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
		return result;
	}
}
