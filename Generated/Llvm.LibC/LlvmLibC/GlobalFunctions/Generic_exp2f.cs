using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_exp2f
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5exp2fEf")]
	[DemangledName("__llvm_libc_20_1_2_::generic::exp2f(float)")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X)
	{
		float result = 0f;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num4 = 0;
		int num5 = 0;
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double num6 = 0.0;
		double x = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double x2 = 0.0;
		double num7 = 0.0;
		int num8 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		float y = 0f;
		int num9 = 0;
		InlineArray2_Single inlineArray2_Single = default(InlineArray2_Single);
		double num10 = 0.0;
		long num11 = 0L;
		long x3 = 0L;
		double num12 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		InlineArray5_Double inlineArray5_Double = default(InlineArray5_Double);
		double num13 = 0.0;
		double num14 = 0.0;
		double z = 0.0;
		double y2 = 0.0;
		double x4 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 994221367;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = -1124882121;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 943884599;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num4 & 0x7FFFFFFF;
			if (!Details_expects_bool_condition_bool.Invoke((uint)num5 >= 1124073472u || (uint)num5 <= 1023410176u, Expected: false))
			{
				goto IL_0711;
			}
			if ((uint)num5 <= 1023410176u)
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num5 <= 847249408u, Expected: false))
				{
					result = 1f + X;
				}
				else
				{
					if (!Details_expects_bool_condition_bool.Invoke((num4 & 0x38428937) == 943884599, Expected: false))
					{
						goto IL_028d;
					}
					if (Details_expects_bool_condition_bool.Invoke(num4 == 994221367, Expected: false))
					{
						result = Fputil_round_result_slightly_down_float.Invoke(1.0020605f);
					}
					else
					{
						if (!Details_expects_bool_condition_bool.Invoke(num4 == -1124882121, Expected: false))
						{
							goto IL_028d;
						}
						result = Fputil_round_result_slightly_down_float.Invoke(0.9795943f);
					}
				}
			}
			else if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)))
			{
				if ((uint)num4 < 2139095040u)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = Fputil_quick_get_round.Invoke();
					int num15;
					if (num8 == 1024 || num8 == 3072)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb.Val);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						num15 = 1;
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						num15 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					switch (num15)
					{
					case 0:
						break;
					default:
						goto IL_0a93;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			}
			else
			{
				if ((uint)num4 < 3272998912u)
				{
					goto IL_0711;
				}
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					result = 0f;
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					result = X;
				}
				else if (Fputil_fenv_is_round_up.Invoke())
				{
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal.Invoke(anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(X, 0f))
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
					}
					result = 0f;
				}
			}
			goto IL_0a93;
		}
		IL_0a93:
		Llvm_lifetime_end_p0.Invoke(4L, &num5);
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_0711:
		Llvm_lifetime_start_p0.Invoke(4L, &y);
		y = float.NaN;
		Llvm_lifetime_start_p0.Invoke(4L, &num9);
		num9 = -1431655766;
		Llvm_lifetime_start_p0.Invoke(8L, &inlineArray2_Single);
		long num16;
		unchecked
		{
			*(float*)(&inlineArray2_Single) = 0.5f;
			((float*)(&inlineArray2_Single))[1] = -0.5f;
			num9 = (int)Fputil_multiply_add_float.Invoke(X, 32f, Unsafe.As<InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_Single, ((X < 0f) ? ((nint)1) : ((nint)0)) * (nint)sizeof(float))));
			y = num9;
			Llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = Fputil_multiply_add_float.Invoke(-1f / 32f, y, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = (long)(num9 >> 5) << 52;
			Llvm_lifetime_start_p0.Invoke(8L, &x3);
			num16 = num9 & 0x1F;
		}
		x3 = unchecked((long*)Llvm_libc_20_1_2_ExpBase_EXP_2_MID.Pointer)[num16] + num11;
		Llvm_lifetime_start_p0.Invoke(8L, &num12);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, x3);
		double num17 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		num12 = num17;
		Llvm_lifetime_start_p0.Invoke(40L, &inlineArray5_Double);
		Llvm_memset_p0_i64.Invoke(&inlineArray5_Double, 0, 40L, isVolatile: false);
		unchecked
		{
			*(double*)(&inlineArray5_Double) = 0.6931471805599453;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))) = 0.2402265069562316;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * (nint)sizeof(double))) = 0.05550410866548564;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * (nint)sizeof(double))) = 0.009618176115429106;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * (nint)sizeof(double))) = 0.0013333564314950786;
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = num10 * num10;
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = Fputil_multiply_add_double.Invoke(num10, *(double*)(&inlineArray5_Double), 1.0);
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(num10, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = Fputil_multiply_add_double.Invoke(num10, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &x4);
			x4 = Fputil_multiply_add_double.Invoke(num13, y2, z);
			result = (float)Fputil_multiply_add_double.Invoke(x4, num13 * num12, num14 * num12);
			Llvm_lifetime_end_p0.Invoke(8L, &x4);
			Llvm_lifetime_end_p0.Invoke(8L, &y2);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_end_p0.Invoke(8L, &num13);
			Llvm_lifetime_end_p0.Invoke(40L, &inlineArray5_Double);
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &x3);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(8L, &inlineArray2_Single);
			Llvm_lifetime_end_p0.Invoke(4L, &num9);
			Llvm_lifetime_end_p0.Invoke(4L, &y);
			goto IL_0a93;
		}
		IL_028d:
		Llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
		Llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
		unchecked
		{
			*(double*)(&inlineArray6_Double) = 0.6931471805599457;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = 0.24022650695910017;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 0.05550410865673368;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = 0.009618129109319968;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 0.0013333780803242515;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = 0.00015403527055187592;
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = X;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num6 * num6;
			Llvm_lifetime_start_p0.Invoke(8L, &a);
			a = Fputil_multiply_add_double.Invoke(num6, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(num6, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(num6, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = Fputil_multiply_add_double.Invoke(x2, num6, 1.0);
			result = (float)num7;
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			goto IL_0a93;
		}
	}
}
