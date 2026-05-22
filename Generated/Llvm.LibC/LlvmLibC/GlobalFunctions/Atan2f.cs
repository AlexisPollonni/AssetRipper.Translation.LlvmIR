using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atan2f
{
	[MangledName("atan2f")]
	[DemangledName("atan2f")]
	public unsafe static float Invoke([MangledName("y")] float Y, [MangledName("x")] float X)
	{
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		InlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair inlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair = default(InlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		sbyte b = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		sbyte b2 = 0;
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int x = 0;
		float num9 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float num10 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		double num11 = 0.0;
		double num12 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		double num13 = 0.0;
		double num14 = 0.0;
		long num15 = 0L;
		long num16 = 0L;
		InlineArray3_InlineArray3_InlineArray2_Double inlineArray3_InlineArray3_InlineArray2_Double = default(InlineArray3_InlineArray3_InlineArray2_Double);
		double num17 = 0.0;
		sbyte b3 = 0;
		double num18 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num19 = 0.0;
		double num20 = 0.0;
		int num21 = 0;
		double num22 = 0.0;
		double num23 = 0.0;
		int num24 = 0;
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
		unchecked
		{
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = Math.PI;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 1.2246467991473532E-16;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = Math.PI / 4.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = Math.PI / 2.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = Math.PI * 3.0 / 4.0;
			Llvm_lifetime_start_p0.Invoke(128L, &inlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair);
			Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair, CONST_ADJ_kemuba.Pointer, 128L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, Y);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			bool num28 = Sign_is_neg.Invoke(&anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			b = (num28 ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb2);
			anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			bool num29 = Sign_is_neg.Invoke(&anon_izyfb2);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb2);
			b2 = (num29 ? ((sbyte)1) : ((sbyte)0));
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, anon_izyfb3.Val);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, anon_izyfb4.Val);
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			Llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = (((uint)num6 <= (uint)num7) ? num7 : num6);
			Llvm_lifetime_start_p0.Invoke(4L, &x);
			x = (((uint)num6 > (uint)num7) ? num7 : num6);
			Llvm_lifetime_start_p0.Invoke(4L, &num9);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3, x);
			float num30 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			num9 = num30;
			Llvm_lifetime_start_p0.Invoke(4L, &num10);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4, num8);
			float num31 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			num10 = num31;
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = num9;
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = num10;
			float result;
			if (Details_expects_bool_condition_bool.Invoke((uint)num8 >= 2139095040u || num11 == 0.0, Expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb5.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num13);
					num13 = X;
					Llvm_lifetime_start_p0.Invoke(8L, &num14);
					num14 = Y;
					Llvm_lifetime_start_p0.Invoke(8L, &num15);
					num15 = ((num13 != 0.0) ? InstructionHelper.Select(num6 == 2139095040, 2, 1) : 0);
					Llvm_lifetime_start_p0.Invoke(8L, &num16);
					num16 = ((num14 != 0.0) ? InstructionHelper.Select(num7 == 2139095040, 2, 1) : 0);
					Llvm_lifetime_start_p0.Invoke(144L, &inlineArray3_InlineArray3_InlineArray2_Double);
					Llvm_memcpy_p0_p0_i64.Invoke(&inlineArray3_InlineArray3_InlineArray2_Double, EXCEPTS_a88r76.Pointer, 144L, isVolatile: false);
					Llvm_lifetime_start_p0.Invoke(8L, &num17);
					num17 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (((b2 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double))) * Unsafe.As<InlineArray3_InlineArray3_InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref inlineArray3_InlineArray3_InlineArray2_Double, (nint)num16 * sizeof(InlineArray3_InlineArray2_Double)), (nint)num15 * sizeof(InlineArray2_Double)), (((b & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
					result = (float)num17;
					Llvm_lifetime_end_p0.Invoke(8L, &num17);
					Llvm_lifetime_end_p0.Invoke(144L, &inlineArray3_InlineArray3_InlineArray2_Double);
					Llvm_lifetime_end_p0.Invoke(8L, &num16);
					Llvm_lifetime_end_p0.Invoke(8L, &num15);
					Llvm_lifetime_end_p0.Invoke(8L, &num14);
					Llvm_lifetime_end_p0.Invoke(8L, &num13);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b3);
				b3 = (((uint)num6 < (uint)num7) ? ((sbyte)1) : ((sbyte)0));
				Llvm_lifetime_start_p0.Invoke(8L, &num18);
				num18 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (((b & 1) == 1 != ((b2 & 1) == 1) != ((b3 & 1) == 1)) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
				*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair, (((b & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair)), (((b2 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(InlineArray2_Llvm_libc_20_1_2_NumberPair)), (((b3 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(Llvm_libc_20_1_2_NumberPair))), 16L, isVolatile: false);
				Llvm_lifetime_start_p0.Invoke(8L, &num19);
				num19 = num11 / num12;
				Llvm_lifetime_start_p0.Invoke(8L, &num20);
				num20 = Fputil_nearest_integer.Invoke(num19 * 16.0);
				Llvm_lifetime_start_p0.Invoke(4L, &num21);
				num21 = (int)num20;
				Llvm_lifetime_start_p0.Invoke(8L, &num22);
				num22 = double.NaN;
				num19 = Fputil_multiply_add_double.Invoke(num20, -0.0625, num19);
				Llvm_lifetime_start_p0.Invoke(8L, &num23);
				num23 = Llvm_libc_20_1_2_atan_eval_gjyy9x.Invoke(num19, num21);
				double num32 = num18;
				double x2 = num19;
				double y = num23;
				double hi = llvm_libc_20_1_2_NumberPair.Hi;
				long num33 = num21;
				num22 = num32 * Fputil_multiply_add_double.Invoke(x2, y, hi + *(double*)((byte*)Llvm_libc_20_1_2_ATAN_COEFFS.Pointer + (nint)num33 * sizeof(InlineArray9_Double)));
				Llvm_lifetime_start_p0.Invoke(4L, &num24);
				num24 = 4;
				Llvm_lifetime_start_p0.Invoke(4L, &num25);
				num25 = 268435455;
				Llvm_lifetime_start_p0.Invoke(4L, &num26);
				num26 = 268435451;
				Llvm_lifetime_start_p0.Invoke(4L, &num27);
				num27 = (int)Cpp_bit_cast_unsigned_long_double.Invoke(&num22) & 0xFFFFFFF;
				result = ((!Details_expects_bool_condition_bool.Invoke((uint)num27 > 4u && (uint)num27 < 268435451u, Expected: true)) ? Anonymous_namespace_atan2f_double_double.Invoke(num11, num12, num19, num21, num20, num18, &llvm_libc_20_1_2_NumberPair) : ((float)num22));
				Llvm_lifetime_end_p0.Invoke(4L, &num27);
				Llvm_lifetime_end_p0.Invoke(4L, &num26);
				Llvm_lifetime_end_p0.Invoke(4L, &num25);
				Llvm_lifetime_end_p0.Invoke(4L, &num24);
				Llvm_lifetime_end_p0.Invoke(8L, &num23);
				Llvm_lifetime_end_p0.Invoke(8L, &num22);
				Llvm_lifetime_end_p0.Invoke(4L, &num21);
				Llvm_lifetime_end_p0.Invoke(8L, &num20);
				Llvm_lifetime_end_p0.Invoke(8L, &num19);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
				Llvm_lifetime_end_p0.Invoke(8L, &num18);
				Llvm_lifetime_end_p0.Invoke(1L, &b3);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(4L, &num10);
			Llvm_lifetime_end_p0.Invoke(4L, &num9);
			Llvm_lifetime_end_p0.Invoke(4L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num8);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(128L, &inlineArray2_InlineArray2_InlineArray2_Llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
			return result;
		}
	}
}
