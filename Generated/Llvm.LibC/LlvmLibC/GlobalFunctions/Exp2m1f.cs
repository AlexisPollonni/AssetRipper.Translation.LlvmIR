using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp2m1f
{
	[MangledName("exp2m1f")]
	[DemangledName("exp2m1f")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_cpp_optional_xmxtsi llvm_libc_20_1_2_cpp_optional_xmxtsi = default(Llvm_libc_20_1_2_cpp_optional_xmxtsi);
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double num3 = 0.0;
		double x = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double num4 = 0.0;
		int num5 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num6 = 0;
		Llvm_libc_20_1_2_cpp_optional_xmxtsi llvm_libc_20_1_2_cpp_optional_xmxtsi2 = default(Llvm_libc_20_1_2_cpp_optional_xmxtsi);
		float y = 0f;
		int num7 = 0;
		InlineArray2_Single inlineArray2_Single = default(InlineArray2_Single);
		double num8 = 0.0;
		long num9 = 0L;
		long x2 = 0L;
		double y2 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		InlineArray5_Double inlineArray5_Double = default(InlineArray5_Double);
		double x3 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double a_ijazrn2 = 0.0;
		double x4 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (!Details_expects_bool_condition_bool.Invoke((uint)num2 >= 1124073472u || (uint)num2 <= 1023410176u, Expected: false))
			{
				goto IL_05ac;
			}
			if ((uint)num2 <= 1023410176u)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
				*(float*)ptr = float.NaN;
				ptr[4] = -86;
				sbyte* ptr2 = ptr + 5;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				long storage = ExceptValues_float_8ul_lookup.Invoke(X_bits: num, This: Llvm_libc_20_1_2_EXP2M1F_EXCEPTS_LO.Pointer);
				*(long*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi.Storage) = storage;
				int num10;
				if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi), Expected: false))
				{
					result = *(float*)Optional_float_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
					num10 = 1;
				}
				else
				{
					num10 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi);
				switch (num10)
				{
				case 0:
					Llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
					Llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
					*(double*)(&inlineArray6_Double) = 0.6931471805599457;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = 0.24022650695910017;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 0.05550410865673368;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = 0.009618129109319968;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 0.0013333780803242515;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = 0.00015403527055187592;
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = X;
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = num3 * num3;
					Llvm_lifetime_start_p0.Invoke(8L, &a);
					a = Fputil_multiply_add_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
					Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
					a_yc74sk = Fputil_multiply_add_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
					Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
					a_ijazrn = Fputil_multiply_add_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
					result = (float)(num4 * num3);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
					Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
					Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
					Llvm_lifetime_end_p0.Invoke(8L, &a);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
					Llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
					break;
				}
			}
			else
			{
				if (!FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)))
				{
					goto IL_05ac;
				}
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_finite.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = Fputil_quick_get_round.Invoke();
					int num10;
					if (num5 == 1024 || num5 == 3072)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb.Val);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						num10 = 1;
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(8);
						num10 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
					switch (num10)
					{
					case 0:
						break;
					default:
						goto IL_0a84;
					}
				}
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			}
			goto IL_0a84;
		}
		IL_0a84:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
		IL_05ac:
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke(!(X > -25f), Expected: false))
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
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = Fputil_quick_get_round.Invoke();
					if (num6 == 2048 || num6 == 3072)
					{
						result = (float)Math.PI * -113f / 355f;
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
						result = -1f;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi2);
				sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi2);
				*(float*)ptr3 = float.NaN;
				ptr3[4] = -86;
				sbyte* ptr4 = ptr3 + 5;
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				long storage2 = ExceptValues_float_3ul_lookup.Invoke(X_bits: num, This: Llvm_libc_20_1_2_EXP2M1F_EXCEPTS_HI.Pointer);
				*(long*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi2.Storage) = storage2;
				int num10;
				if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi2), Expected: false))
				{
					result = *(float*)Optional_float_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi2);
					num10 = 1;
				}
				else
				{
					num10 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi2);
				switch (num10)
				{
				case 0:
				{
					Llvm_lifetime_start_p0.Invoke(4L, &y);
					y = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = -1431655766;
					Llvm_lifetime_start_p0.Invoke(8L, &inlineArray2_Single);
					*(float*)(&inlineArray2_Single) = 0.5f;
					((float*)(&inlineArray2_Single))[1] = -0.5f;
					num7 = (int)Fputil_multiply_add_float.Invoke(X, 32f, Unsafe.As<InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_Single, ((X < 0f) ? ((nint)1) : ((nint)0)) * (nint)sizeof(float))));
					y = num7;
					Llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = Fputil_multiply_add_float.Invoke(-1f / 32f, y, X);
					Llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = (long)(num7 >> 5) << 52;
					Llvm_lifetime_start_p0.Invoke(8L, &x2);
					long num11 = num7 & 0x1F;
					checked
					{
						x2 = unchecked((long*)Llvm_libc_20_1_2_ExpBase_EXP_2_MID.Pointer)[num11] + num9;
						Llvm_lifetime_start_p0.Invoke(8L, &y2);
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
						FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, x2);
						double num12 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
						y2 = num12;
						Llvm_lifetime_start_p0.Invoke(40L, &inlineArray5_Double);
						Llvm_memset_p0_i64.Invoke(&inlineArray5_Double, 0, 40L, isVolatile: false);
					}
					*(double*)(&inlineArray5_Double) = 0.6931471805599453;
					Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))) = 0.2402265069562316;
					Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * (nint)sizeof(double))) = 0.05550410866548564;
					Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * (nint)sizeof(double))) = 0.009618176115429106;
					Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * (nint)sizeof(double))) = 0.0013333564314950786;
					Llvm_lifetime_start_p0.Invoke(8L, &x3);
					x3 = num8 * num8;
					Llvm_lifetime_start_p0.Invoke(8L, &a2);
					a2 = Fputil_multiply_add_double.Invoke(num8, *(double*)(&inlineArray5_Double), 1.0);
					Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
					a_yc74sk2 = Fputil_multiply_add_double.Invoke(num8, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))));
					Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn2);
					a_ijazrn2 = Fputil_multiply_add_double.Invoke(num8, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * sizeof(double))));
					Llvm_lifetime_start_p0.Invoke(8L, &x4);
					x4 = Fputil_polyeval_double_double_double.Invoke(x3, a2, a_yc74sk2, a_ijazrn2);
					result = (float)Fputil_multiply_add_double.Invoke(x4, y2, -1.0);
					Llvm_lifetime_end_p0.Invoke(8L, &x4);
					Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn2);
					Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
					Llvm_lifetime_end_p0.Invoke(8L, &a2);
					Llvm_lifetime_end_p0.Invoke(8L, &x3);
					Llvm_lifetime_end_p0.Invoke(40L, &inlineArray5_Double);
					Llvm_lifetime_end_p0.Invoke(8L, &y2);
					Llvm_lifetime_end_p0.Invoke(8L, &x2);
					Llvm_lifetime_end_p0.Invoke(8L, &num9);
					Llvm_lifetime_end_p0.Invoke(8L, &num8);
					Llvm_lifetime_end_p0.Invoke(8L, &inlineArray2_Single);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(4L, &y);
					break;
				}
				}
			}
			goto IL_0a84;
		}
	}
}
