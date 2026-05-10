using System;
using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class atan2f
{
	public unsafe static float Invoke(float y, float x)
	{
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		InlineArray2_InlineArray2_InlineArray2_NumberPair inlineArray2_InlineArray2_InlineArray2_NumberPair = default(InlineArray2_InlineArray2_InlineArray2_NumberPair);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		sbyte b2 = 0;
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int x2 = 0;
		float num9 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		float num10 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		double num11 = 0.0;
		double num12 = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		double num13 = 0.0;
		double num14 = 0.0;
		long num15 = 0L;
		long num16 = 0L;
		InlineArray3_InlineArray3_InlineArray2_Double inlineArray3_InlineArray3_InlineArray2_Double = default(InlineArray3_InlineArray3_InlineArray2_Double);
		double num17 = 0.0;
		sbyte b3 = 0;
		double num18 = 0.0;
		NumberPair numberPair = default(NumberPair);
		double num19 = 0.0;
		double num20 = 0.0;
		int num21 = 0;
		double num22 = 0.0;
		double num23 = 0.0;
		int num24 = 0;
		int num25 = 0;
		int num26 = 0;
		int num27 = 0;
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
		unchecked
		{
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = Math.PI;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 1.2246467991473532E-16;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = Math.PI / 4.0;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = Math.PI / 2.0;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = Math.PI * 3.0 / 4.0;
			llvm_lifetime_start_p0.Invoke(128L, &inlineArray2_InlineArray2_InlineArray2_NumberPair);
			llvm_memcpy_p0_p0_i64.Invoke(&inlineArray2_InlineArray2_InlineArray2_NumberPair, CONST_ADJ_kemuba.Pointer, 128L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, y);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
			bool num28 = Sign_is_neg_const.Invoke(&anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			b = (num28 ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
			anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs3);
			bool num29 = Sign_is_neg_const.Invoke(&anon_izyfb9);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
			b2 = (num29 ? ((sbyte)1) : ((sbyte)0));
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
			fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb10.val);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
			fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs3, anon_izyfb11.val);
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs3);
			llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = (((uint)num6 <= (uint)num7) ? num7 : num6);
			llvm_lifetime_start_p0.Invoke(4L, &x2);
			x2 = (((uint)num6 > (uint)num7) ? num7 : num6);
			llvm_lifetime_start_p0.Invoke(4L, &num9);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs4, x2);
			float num30 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			num9 = num30;
			llvm_lifetime_start_p0.Invoke(4L, &num10);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs5, num8);
			float num31 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			num10 = num31;
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = num9;
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = num10;
			float result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((uint)num8 < 2139095040u) ? (num11 == 0.0) : true, expected: false))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs3))
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb12.val, 0);
					fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num13);
					num13 = x;
					llvm_lifetime_start_p0.Invoke(8L, &num14);
					num14 = y;
					llvm_lifetime_start_p0.Invoke(8L, &num15);
					num15 = ((num13 != 0.0) ? InstructionHelper.Select(num6 == 2139095040, 2, 1) : 0);
					llvm_lifetime_start_p0.Invoke(8L, &num16);
					num16 = ((num14 != 0.0) ? InstructionHelper.Select(num7 == 2139095040, 2, 1) : 0);
					llvm_lifetime_start_p0.Invoke(144L, &inlineArray3_InlineArray3_InlineArray2_Double);
					llvm_memcpy_p0_p0_i64.Invoke(&inlineArray3_InlineArray3_InlineArray2_Double, EXCEPTS_a88r76.Pointer, 144L, isVolatile: false);
					llvm_lifetime_start_p0.Invoke(8L, &num17);
					num17 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (((b2 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double))) * Unsafe.As<InlineArray3_InlineArray3_InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref inlineArray3_InlineArray3_InlineArray2_Double, (nint)num16 * sizeof(InlineArray3_InlineArray2_Double)), (nint)num15 * sizeof(InlineArray2_Double)), (((b & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
					result = (float)num17;
					llvm_lifetime_end_p0.Invoke(8L, &num17);
					llvm_lifetime_end_p0.Invoke(144L, &inlineArray3_InlineArray3_InlineArray2_Double);
					llvm_lifetime_end_p0.Invoke(8L, &num16);
					llvm_lifetime_end_p0.Invoke(8L, &num15);
					llvm_lifetime_end_p0.Invoke(8L, &num14);
					llvm_lifetime_end_p0.Invoke(8L, &num13);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b3);
				b3 = (((uint)num6 < (uint)num7) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(8L, &num18);
				num18 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (((b & 1) == 1 != ((b2 & 1) == 1) != ((b3 & 1) == 1)) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
				llvm_lifetime_start_p0.Invoke(16L, &numberPair);
				*(double*)(&numberPair) = double.NaN;
				((double*)(&numberPair))[1] = double.NaN;
				llvm_memcpy_p0_p0_i64.Invoke(&numberPair, Unsafe.AsPointer(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_InlineArray2_NumberPair, (((b & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(InlineArray2_InlineArray2_NumberPair)), (((b2 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(InlineArray2_NumberPair)), (((b3 & 1) == 1) ? ((nint)1) : ((nint)0)) * (nint)sizeof(NumberPair))), 16L, isVolatile: false);
				llvm_lifetime_start_p0.Invoke(8L, &num19);
				num19 = num11 / num12;
				llvm_lifetime_start_p0.Invoke(8L, &num20);
				num20 = fputil_nearest_integer_double.Invoke(num19 * 16.0);
				llvm_lifetime_start_p0.Invoke(4L, &num21);
				num21 = (int)num20;
				llvm_lifetime_start_p0.Invoke(8L, &num22);
				num22 = double.NaN;
				num19 = fputil_multiply_add_double_double_double.Invoke(num20, -0.0625, num19);
				llvm_lifetime_start_p0.Invoke(8L, &num23);
				num23 = atan_eval_double_unsigned_int_60.Invoke(num19, num21);
				double num32 = num18;
				double x3 = num19;
				double y2 = num23;
				double hi = numberPair.hi;
				long num33 = num21;
				num22 = num32 * fputil_multiply_add_double_double_double.Invoke(x3, y2, hi + *(double*)((byte*)ATAN_COEFFS.Pointer + (nint)num33 * sizeof(InlineArray9_Double)));
				llvm_lifetime_start_p0.Invoke(4L, &num24);
				num24 = 4;
				llvm_lifetime_start_p0.Invoke(4L, &num25);
				num25 = 268435455;
				llvm_lifetime_start_p0.Invoke(4L, &num26);
				num26 = 268435451;
				llvm_lifetime_start_p0.Invoke(4L, &num27);
				num27 = (int)cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num22) & 0xFFFFFFF;
				result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num27 > 4u && (uint)num27 < 268435451u, expected: true)) ? anonymous_namespace_atan2f_double_double_double_double_double_int_double_double_NumberPair_double_const.Invoke(num11, num12, num19, num21, num20, num18, &numberPair) : ((float)num22));
				llvm_lifetime_end_p0.Invoke(4L, &num27);
				llvm_lifetime_end_p0.Invoke(4L, &num26);
				llvm_lifetime_end_p0.Invoke(4L, &num25);
				llvm_lifetime_end_p0.Invoke(4L, &num24);
				llvm_lifetime_end_p0.Invoke(8L, &num23);
				llvm_lifetime_end_p0.Invoke(8L, &num22);
				llvm_lifetime_end_p0.Invoke(4L, &num21);
				llvm_lifetime_end_p0.Invoke(8L, &num20);
				llvm_lifetime_end_p0.Invoke(8L, &num19);
				llvm_lifetime_end_p0.Invoke(16L, &numberPair);
				llvm_lifetime_end_p0.Invoke(8L, &num18);
				llvm_lifetime_end_p0.Invoke(1L, &b3);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(4L, &num10);
			llvm_lifetime_end_p0.Invoke(4L, &num9);
			llvm_lifetime_end_p0.Invoke(4L, &x2);
			llvm_lifetime_end_p0.Invoke(4L, &num8);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			llvm_lifetime_end_p0.Invoke(128L, &inlineArray2_InlineArray2_InlineArray2_NumberPair);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
			return result;
		}
	}
}
