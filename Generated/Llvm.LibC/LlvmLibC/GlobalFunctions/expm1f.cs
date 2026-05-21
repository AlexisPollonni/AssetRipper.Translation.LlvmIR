using System;
using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expm1f
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num7 = 0.0;
		InlineArray7_Double inlineArray7_Double = default(InlineArray7_Double);
		double num8 = 0.0;
		double num9 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double x2 = 0.0;
		float num10 = 0f;
		int num11 = 0;
		double x3 = 0.0;
		double num12 = 0.0;
		double num13 = 0.0;
		double x4 = 0.0;
		double y = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (details_expects_bool_condition_bool.Invoke(num == 1043709637, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_quick_get_round.Invoke();
				result = ((num3 != 0 && num3 != 2048) ? 0.19421078f : 0.1942108f);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			else if (details_expects_bool_condition_bool.Invoke(num == -1111374133, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = fputil_quick_get_round.Invoke();
				result = ((num4 != 0 && num4 != 1024) ? (-0.09027911f) : (-0.09027912f));
				llvm_lifetime_end_p0.Invoke(4L, &num4);
			}
			else
			{
				if (!details_expects_bool_condition_bool.Invoke((uint)num2 >= 1099604259u, expected: false))
				{
					goto IL_0424;
				}
				if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
				{
					if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs2))
					{
						result = -1f;
					}
					else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2))
					{
						result = x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = fputil_quick_get_round.Invoke();
						result = ((num5 != 2048 && num5 != 3072) ? (-1f) : ((float)Math.PI * -113f / 355f));
						llvm_lifetime_end_p0.Invoke(4L, &num5);
					}
				}
				else
				{
					if ((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) < 1118961664u)
					{
						goto IL_0424;
					}
					if ((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) < 2139095040u)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = fputil_quick_get_round.Invoke();
						int num14;
						if (num6 == 1024 || num6 == 3072)
						{
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb8.val);
							fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
							result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
							num14 = 1;
						}
						else
						{
							fputil_set_errno_if_required.Invoke(34);
							fputil_raise_except_if_required.Invoke(8);
							num14 = 0;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num6);
						switch (num14)
						{
						case 0:
							break;
						default:
							goto IL_0897;
						}
					}
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb9.val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = x + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
			}
			goto IL_0897;
		}
		IL_0897:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
		IL_0424:
		unchecked
		{
			if ((uint)num2 < 1031798784u)
			{
				if ((uint)num2 < 855638016u)
				{
					if (details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) == int.MinValue, expected: false))
					{
						result = x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = x;
						result = (float)fputil_multiply_add_double.Invoke(num7, num7, num7);
						llvm_lifetime_end_p0.Invoke(8L, &num7);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(56L, &inlineArray7_Double);
					*(double*)(&inlineArray7_Double) = 0.5;
					((double*)(&inlineArray7_Double))[1] = 0.16666666666668464;
					((double*)(&inlineArray7_Double))[2L] = 0.04166666666666248;
					((double*)(&inlineArray7_Double))[3L] = 0.008333333296530616;
					((double*)(&inlineArray7_Double))[4L] = 0.0013888888901106868;
					((double*)(&inlineArray7_Double))[5L] = 0.00019843153859331735;
					((double*)(&inlineArray7_Double))[6L] = 2.480257494580395E-05;
					llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = x;
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = num8 * num8;
					llvm_lifetime_start_p0.Invoke(8L, &a);
					a = fputil_multiply_add_double.Invoke(num8, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, sizeof(double))), *(double*)(&inlineArray7_Double));
					llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
					a_yc74sk = fputil_multiply_add_double.Invoke(num8, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)2 * sizeof(double))));
					llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
					a_ijazrn = fputil_multiply_add_double.Invoke(num8, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)4 * sizeof(double))));
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = fputil_polyeval_double_double_double_double.Invoke(num9, a, a_yc74sk, a_ijazrn, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)6 * sizeof(double))));
					result = (float)fputil_multiply_add_double.Invoke(x2, num9, num8);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
					llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
					llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
					llvm_lifetime_end_p0.Invoke(8L, &a);
					llvm_lifetime_end_p0.Invoke(8L, &num9);
					llvm_lifetime_end_p0.Invoke(8L, &num8);
					llvm_lifetime_end_p0.Invoke(56L, &inlineArray7_Double);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num10);
				num10 = fputil_nearest_integer.Invoke(x * 128f);
				llvm_lifetime_start_p0.Invoke(4L, &num11);
				num11 = (int)num10;
				llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = fputil_multiply_add_float.Invoke(num10, -1f / 128f, x);
				num11 = checked(num11 + 13312);
				llvm_lifetime_start_p0.Invoke(8L, &num12);
				long num15 = num11 >> 7;
				num12 = ((double*)EXP_M1.Pointer)[num15];
				llvm_lifetime_start_p0.Invoke(8L, &num13);
				long num16 = num11 & 0x7F;
				num13 = ((double*)EXP_M2.Pointer)[num16];
				llvm_lifetime_start_p0.Invoke(8L, &x4);
				x4 = num12 * num13;
				llvm_lifetime_start_p0.Invoke(8L, &y);
				y = fputil_polyeval_double_double_double_double_double.Invoke(x3, 1.0, 0.9999999999997574, 0.5000000000002021, 0.16666679382778612, 0.041666666671038154);
				result = (float)fputil_multiply_add_double.Invoke(x4, y, -1.0);
				llvm_lifetime_end_p0.Invoke(8L, &y);
				llvm_lifetime_end_p0.Invoke(8L, &x4);
				llvm_lifetime_end_p0.Invoke(8L, &num13);
				llvm_lifetime_end_p0.Invoke(8L, &num12);
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(4L, &num11);
				llvm_lifetime_end_p0.Invoke(4L, &num10);
			}
			goto IL_0897;
		}
	}
}
