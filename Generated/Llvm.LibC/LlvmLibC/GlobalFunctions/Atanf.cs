using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atanf
{
	[MangledName("atanf")]
	[DemangledName("atanf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		InlineArray2_Double inlineArray2_Double2 = default(InlineArray2_Double);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num = 0;
		double num2 = 0.0;
		double z = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double num5 = 0.0;
		double x = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double y = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double z2 = 0.0;
		double num8 = 0.0;
		int num9 = 0;
		double num10 = 0.0;
		float num11 = 0f;
		float num12 = 0f;
		double y2 = 0.0;
		double num13 = 0.0;
		Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
		float result;
		unchecked
		{
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double2);
			*(double*)(&inlineArray2_Double2) = Math.PI / 2.0;
			((double*)(&inlineArray2_Double2))[1] = -Math.PI / 2.0;
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
			FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs, anon_izyfb2.Val);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			if (Details_expects_bool_condition_bool.Invoke((uint)num <= 1031798784u || (uint)num >= 1098907648u, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = X;
				Llvm_lifetime_start_p0.Invoke(8L, &z);
				z = 0.0;
				if (!Details_expects_bool_condition_bool.Invoke((uint)num >= 1098907648u, Expected: false))
				{
					goto IL_02ff;
				}
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double2, (Sign_is_neg.Invoke(&anon_izyfb) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
					result = (float)num3;
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
				else
				{
					if (!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs))
					{
						num2 = -1.0 / num2;
						z = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double2, (Sign_is_neg.Invoke(&anon_izyfb) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
						goto IL_02ff;
					}
					result = X;
				}
				goto IL_05a2;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = double.NaN;
			Llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = double.NaN;
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = double.NaN;
			Llvm_lifetime_start_p0.Invoke(4L, &num9);
			num9 = -1431655766;
			if ((uint)num > 1065353216u)
			{
				num7 = 1.0 / (double)FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = Fputil_nearest_integer.Invoke(num7 * 16.0);
				num7 = Fputil_multiply_add_double.Invoke(num10, -0.0625, num7);
				num9 = (int)num10;
				num8 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (Sign_is_pos.Invoke(&anon_izyfb) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
				double x2 = num8;
				long num14 = num9;
				z2 = Fputil_multiply_add_double.Invoke(x2, *(double*)((byte*)ATAN_COEFFS.Pointer + (nint)num14 * sizeof(InlineArray9_Double)), Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double2, (Sign_is_neg.Invoke(&anon_izyfb) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double))));
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
			}
			else
			{
				if (Details_expects_bool_condition_bool.Invoke(num == 1032678179, Expected: false))
				{
					result = ((!Sign_is_pos.Invoke(&anon_izyfb)) ? Fputil_round_result_slightly_up_float.Invoke(-0.06894257f) : Fputil_round_result_slightly_down_float.Invoke(0.06894257f));
					goto IL_084a;
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num11);
				num11 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
				Llvm_lifetime_start_p0.Invoke(4L, &num12);
				num12 = Fputil_nearest_integer.Invoke(num11 * 16f);
				num11 = Fputil_multiply_add_float.Invoke(num12, -0.0625f, num11);
				num7 = num11;
				num9 = (int)num12;
				num8 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (Sign_is_neg.Invoke(&anon_izyfb) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double)));
				double num15 = num8;
				long num16 = num9;
				z2 = num15 * *(double*)((byte*)ATAN_COEFFS.Pointer + (nint)num16 * sizeof(InlineArray9_Double));
				Llvm_lifetime_end_p0.Invoke(4L, &num12);
				Llvm_lifetime_end_p0.Invoke(4L, &num11);
			}
			Llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = Atan_eval_kp87ny.Invoke(num7, num9);
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = Fputil_multiply_add_double.Invoke(num8 * num7, y2, z2);
			result = (float)num13;
			Llvm_lifetime_end_p0.Invoke(8L, &num13);
			Llvm_lifetime_end_p0.Invoke(8L, &y2);
			goto IL_084a;
		}
		IL_084a:
		Llvm_lifetime_end_p0.Invoke(4L, &num9);
		Llvm_lifetime_end_p0.Invoke(8L, &num8);
		Llvm_lifetime_end_p0.Invoke(8L, &z2);
		Llvm_lifetime_end_p0.Invoke(8L, &num7);
		goto IL_088c;
		IL_088c:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double2);
		Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
		return result;
		IL_02ff:
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs), Expected: false))
			{
				result = X;
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num < 964689920u, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = X;
				result = (float)Fputil_multiply_add_double.Invoke(num4, -2.980232238769531E-08, num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
				Llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
				*(double*)(&inlineArray6_Double) = 1.0;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = -1.0 / 3.0;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 0.2;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = -1.0 / 7.0;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 1.0 / 9.0;
				Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = -1.0 / 11.0;
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = num2 * num2;
				Llvm_lifetime_start_p0.Invoke(8L, &x);
				x = num5 * num5;
				Llvm_lifetime_start_p0.Invoke(8L, &a);
				a = Fputil_multiply_add_double.Invoke(num5, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
				Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
				a_yc74sk = Fputil_multiply_add_double.Invoke(num5, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
				Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
				a_ijazrn = Fputil_multiply_add_double.Invoke(num5, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
				Llvm_lifetime_start_p0.Invoke(8L, &y);
				y = Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = Fputil_multiply_add_double.Invoke(num2, y, z);
				result = (float)num6;
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &y);
				Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
				Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
				Llvm_lifetime_end_p0.Invoke(8L, &a);
				Llvm_lifetime_end_p0.Invoke(8L, &x);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			}
			goto IL_05a2;
		}
		IL_05a2:
		Llvm_lifetime_end_p0.Invoke(8L, &z);
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		goto IL_088c;
	}
}
