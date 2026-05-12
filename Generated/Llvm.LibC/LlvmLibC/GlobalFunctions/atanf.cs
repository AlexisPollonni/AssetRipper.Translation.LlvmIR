using System;
using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class atanf
{
	public unsafe static float Invoke(float x)
	{
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		InlineArray2_Double inlineArray2_Double2 = default(InlineArray2_Double);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num = 0;
		double num2 = 0.0;
		double z = 0.0;
		double num3 = 0.0;
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double num4 = 0.0;
		double x2 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double y = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double z2 = 0.0;
		double num7 = 0.0;
		int num8 = 0;
		double num9 = 0.0;
		float num10 = 0f;
		float num11 = 0f;
		double y2 = 0.0;
		double num12 = 0.0;
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
		float result;
		unchecked
		{
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double2);
			*(double*)(&inlineArray2_Double2) = Math.PI / 2.0;
			((double*)(&inlineArray2_Double2))[1] = -Math.PI / 2.0;
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
			fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb9.val);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((uint)num > 1031798784u) ? ((uint)num >= 1098907648u) : true, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = x;
				llvm_lifetime_start_p0.Invoke(8L, &z);
				z = 0.0;
				if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num >= 1098907648u, expected: false))
				{
					goto IL_02f4;
				}
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double2, (Sign_is_neg_const.Invoke(&anon_izyfb8) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
					result = (float)num3;
					llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
				else
				{
					if (!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
					{
						num2 = -1.0 / num2;
						z = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double2, (Sign_is_neg_const.Invoke(&anon_izyfb8) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
						goto IL_02f4;
					}
					result = x;
				}
				goto IL_056d;
			}
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = double.NaN;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = double.NaN;
			llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = -1431655766;
			if ((uint)num > 1065353216u)
			{
				num6 = 1.0 / (double)fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = fputil_nearest_integer_double.Invoke(num6 * 16.0);
				num6 = fputil_multiply_add_double_double_double.Invoke(num9, -0.0625, num6);
				num8 = (int)num9;
				num7 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (Sign_is_pos_const.Invoke(&anon_izyfb8) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
				double x3 = num7;
				long num13 = num8;
				z2 = fputil_multiply_add_double_double_double.Invoke(x3, *(double*)((byte*)ATAN_COEFFS.Pointer + (nint)num13 * sizeof(InlineArray9_Double)), Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double2, (Sign_is_neg_const.Invoke(&anon_izyfb8) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double))));
				llvm_lifetime_end_p0.Invoke(8L, &num9);
			}
			else
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 1032678179, expected: false))
				{
					result = ((!Sign_is_pos_const.Invoke(&anon_izyfb8)) ? float_fputil_round_result_slightly_up_float_float.Invoke(-0.06894257f) : float_fputil_round_result_slightly_down_float_float.Invoke(0.06894257f));
					goto IL_0815;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num10);
				num10 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_lifetime_start_p0.Invoke(4L, &num11);
				num11 = fputil_nearest_integer_float.Invoke(num10 * 16f);
				num10 = fputil_multiply_add_float_float_float.Invoke(num11, -0.0625f, num10);
				num6 = num10;
				num8 = (int)num11;
				num7 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (Sign_is_neg_const.Invoke(&anon_izyfb8) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
				double num14 = num7;
				long num15 = num8;
				z2 = num14 * *(double*)((byte*)ATAN_COEFFS.Pointer + (nint)num15 * sizeof(InlineArray9_Double));
				llvm_lifetime_end_p0.Invoke(4L, &num11);
				llvm_lifetime_end_p0.Invoke(4L, &num10);
			}
			llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = atan_eval_double_unsigned_int.Invoke(num6, num8);
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = fputil_multiply_add_double_double_double.Invoke(num7 * num6, y2, z2);
			result = (float)num12;
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			goto IL_0815;
		}
		IL_0815:
		llvm_lifetime_end_p0.Invoke(4L, &num8);
		llvm_lifetime_end_p0.Invoke(8L, &num7);
		llvm_lifetime_end_p0.Invoke(8L, &z2);
		llvm_lifetime_end_p0.Invoke(8L, &num6);
		goto IL_0857;
		IL_0857:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double2);
		llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
		return result;
		IL_02f4:
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2), expected: false))
			{
				result = x;
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num < 964689920u, expected: false))
			{
				result = fputil_multiply_add_float_float_float.Invoke(x, -2.9802322E-08f, x);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
				llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
				*(double*)(&inlineArray6_Double) = 1.0;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = -1.0 / 3.0;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 0.2;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = -1.0 / 7.0;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 1.0 / 9.0;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = -1.0 / 11.0;
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = num2 * num2;
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = num4 * num4;
				llvm_lifetime_start_p0.Invoke(8L, &a);
				a = fputil_multiply_add_double_double_double.Invoke(num4, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
				llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
				a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num4, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
				llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
				a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num4, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
				llvm_lifetime_start_p0.Invoke(8L, &y);
				y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x2, a, a_yc74sk, a_ijazrn);
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = fputil_multiply_add_double_double_double.Invoke(num2, y, z);
				result = (float)num5;
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &y);
				llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
				llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
				llvm_lifetime_end_p0.Invoke(8L, &a);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			}
			goto IL_056d;
		}
		IL_056d:
		llvm_lifetime_end_p0.Invoke(8L, &z);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		goto IL_0857;
	}
}
