using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expm1f
{
	[MangledName("expm1f")]
	[DemangledName("expm1f")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double num7 = 0.0;
		InlineArray7_Double inlineArray7_Double = default(InlineArray7_Double);
		double num8 = 0.0;
		double num9 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double x = 0.0;
		float num10 = 0f;
		int num11 = 0;
		double x2 = 0.0;
		double num12 = 0.0;
		double num13 = 0.0;
		double x3 = 0.0;
		double y = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (Details_expects_bool_condition_bool.Invoke(num == 1043709637, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = Fputil_quick_get_round.Invoke();
				result = ((num3 != 0 && num3 != 2048) ? 0.19421078f : 0.1942108f);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			else if (Details_expects_bool_condition_bool.Invoke(num == -1111374133, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = Fputil_quick_get_round.Invoke();
				result = ((num4 != 0 && num4 != 1024) ? (-0.09027911f) : (-0.09027912f));
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
			}
			else
			{
				if (!Details_expects_bool_condition_bool.Invoke((uint)num2 >= 1099604259u, Expected: false))
				{
					goto IL_0424;
				}
				if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)))
				{
					if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
					{
						result = -1f;
					}
					else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = Fputil_quick_get_round.Invoke();
						result = ((num5 != 2048 && num5 != 3072) ? (-1f) : ((float)Math.PI * -113f / 355f));
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
					}
				}
				else
				{
					if ((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) < 1118961664u)
					{
						goto IL_0424;
					}
					if ((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) < 2139095040u)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = Fputil_quick_get_round.Invoke();
						int num14;
						if (num6 == 1024 || num6 == 3072)
						{
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb.Val);
							llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
							result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
							num14 = 1;
						}
						else
						{
							Fputil_set_errno_if_required.Invoke(34);
							Fputil_raise_except_if_required.Invoke(8);
							num14 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num6);
						switch (num14)
						{
						case 0:
							break;
						default:
							goto IL_0897;
						}
					}
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				}
			}
			goto IL_0897;
		}
		IL_0897:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
		IL_0424:
		unchecked
		{
			if ((uint)num2 < 1031798784u)
			{
				if ((uint)num2 < 855638016u)
				{
					if (Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) == int.MinValue, Expected: false))
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = X;
						result = (float)Fputil_multiply_add_double.Invoke(num7, num7, num7);
						Llvm_lifetime_end_p0.Invoke(8L, &num7);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(56L, &inlineArray7_Double);
					*(double*)(&inlineArray7_Double) = 0.5;
					((double*)(&inlineArray7_Double))[1] = 0.16666666666668464;
					((double*)(&inlineArray7_Double))[2L] = 0.04166666666666248;
					((double*)(&inlineArray7_Double))[3L] = 0.008333333296530616;
					((double*)(&inlineArray7_Double))[4L] = 0.0013888888901106868;
					((double*)(&inlineArray7_Double))[5L] = 0.00019843153859331735;
					((double*)(&inlineArray7_Double))[6L] = 2.480257494580395E-05;
					Llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = X;
					Llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = num8 * num8;
					Llvm_lifetime_start_p0.Invoke(8L, &a);
					a = Fputil_multiply_add_double.Invoke(num8, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, sizeof(double))), *(double*)(&inlineArray7_Double));
					Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
					a_yc74sk = Fputil_multiply_add_double.Invoke(num8, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)2 * sizeof(double))));
					Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
					a_ijazrn = Fputil_multiply_add_double.Invoke(num8, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)4 * sizeof(double))));
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = Fputil_polyeval_double_double_double_double.Invoke(num9, a, a_yc74sk, a_ijazrn, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)6 * sizeof(double))));
					result = (float)Fputil_multiply_add_double.Invoke(x, num9, num8);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
					Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
					Llvm_lifetime_end_p0.Invoke(8L, &a);
					Llvm_lifetime_end_p0.Invoke(8L, &num9);
					Llvm_lifetime_end_p0.Invoke(8L, &num8);
					Llvm_lifetime_end_p0.Invoke(56L, &inlineArray7_Double);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num10);
				num10 = Fputil_nearest_integer.Invoke(X * 128f);
				Llvm_lifetime_start_p0.Invoke(4L, &num11);
				num11 = (int)num10;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = Fputil_multiply_add_float.Invoke(num10, -1f / 128f, X);
				num11 = checked(num11 + 13312);
				Llvm_lifetime_start_p0.Invoke(8L, &num12);
				long num15 = num11 >> 7;
				num12 = ((double*)Llvm_libc_20_1_2_EXP_M1.Pointer)[num15];
				Llvm_lifetime_start_p0.Invoke(8L, &num13);
				long num16 = num11 & 0x7F;
				num13 = ((double*)Llvm_libc_20_1_2_EXP_M2.Pointer)[num16];
				Llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = num12 * num13;
				Llvm_lifetime_start_p0.Invoke(8L, &y);
				y = Fputil_polyeval_double_double_double_double_double.Invoke(x2, 1.0, 0.9999999999997574, 0.5000000000002021, 0.16666679382778612, 0.041666666671038154);
				result = (float)Fputil_multiply_add_double.Invoke(x3, y, -1.0);
				Llvm_lifetime_end_p0.Invoke(8L, &y);
				Llvm_lifetime_end_p0.Invoke(8L, &x3);
				Llvm_lifetime_end_p0.Invoke(8L, &num13);
				Llvm_lifetime_end_p0.Invoke(8L, &num12);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(4L, &num11);
				Llvm_lifetime_end_p0.Invoke(4L, &num10);
			}
			goto IL_0897;
		}
	}
}
