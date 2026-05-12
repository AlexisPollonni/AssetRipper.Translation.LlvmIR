using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic5exp2fEf")]
[DemangledName("__llvm_libc_20_1_2_::generic::exp2f(float)")]
internal static partial class generic_exp2f_float
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num4 = 0;
		int num5 = 0;
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double num6 = 0.0;
		double x2 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double x3 = 0.0;
		double num7 = 0.0;
		int num8 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		float num9 = 0f;
		int num10 = 0;
		double num11 = 0.0;
		long num12 = 0L;
		long x4 = 0L;
		double num13 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		InlineArray5_Double inlineArray5_Double = default(InlineArray5_Double);
		double num14 = 0.0;
		double num15 = 0.0;
		double z = 0.0;
		double y = 0.0;
		double x5 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 994221367;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = -1124882121;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 943884599;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num4 & 0x7FFFFFFF;
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(((uint)num5 < 1124073472u) ? ((uint)num5 <= 1023410176u) : true, expected: false))
			{
				goto IL_0709;
			}
			if ((uint)num5 <= 1023410176u)
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num5 <= 847249408u, expected: false))
				{
					result = 1f + x;
				}
				else
				{
					if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke((num4 & 0x38428937) == 943884599, expected: false))
					{
						goto IL_0285;
					}
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num4 == 994221367, expected: false))
					{
						result = float_fputil_round_result_slightly_down_float_float.Invoke(1.0020605f);
					}
					else
					{
						if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num4 == -1124882121, expected: false))
						{
							goto IL_0285;
						}
						result = float_fputil_round_result_slightly_down_float_float.Invoke(0.9795943f);
					}
				}
			}
			else if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
			{
				if ((uint)num4 < 2139095040u)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = fputil_quick_get_round.Invoke();
					int num16;
					if (num8 == 1024 || num8 == 3072)
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal_Sign.Invoke(anon_izyfb8.val);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						num16 = 1;
					}
					else
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(8);
						num16 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					switch (num16)
					{
					case 0:
						break;
					default:
						goto IL_0a33;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb9.val);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				result = x + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			}
			else
			{
				if ((uint)num4 < 3272998912u)
				{
					goto IL_0709;
				}
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = 0f;
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = x;
				}
				else if (fputil_fenv_is_round_up.Invoke())
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal_Sign.Invoke(anon_izyfb10.val);
					fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(x, 0f))
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(16);
					}
					result = 0f;
				}
			}
			goto IL_0a33;
		}
		IL_0a33:
		llvm_lifetime_end_p0.Invoke(4L, &num5);
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
		IL_0709:
		llvm_lifetime_start_p0.Invoke(4L, &num9);
		num9 = float.NaN;
		llvm_lifetime_start_p0.Invoke(4L, &num10);
		num10 = -1431655766;
		num9 = fputil_nearest_integer_float.Invoke(x * 32f);
		long num17;
		unchecked
		{
			num10 = (int)num9;
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = fputil_multiply_add_float_float_float.Invoke(-1f / 32f, num9, x);
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = (long)(num10 >> 5) << 52;
			llvm_lifetime_start_p0.Invoke(8L, &x4);
			num17 = num10 & 0x1F;
		}
		x4 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num17] + num12;
		llvm_lifetime_start_p0.Invoke(8L, &num13);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x4);
		double num18 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		num13 = num18;
		llvm_lifetime_start_p0.Invoke(40L, &inlineArray5_Double);
		llvm_memset_p0_i64.Invoke(&inlineArray5_Double, 0, 40L, isVolatile: false);
		unchecked
		{
			*(double*)(&inlineArray5_Double) = 0.6931471805599453;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))) = 0.2402265069562316;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * (nint)sizeof(double))) = 0.05550410866548564;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * (nint)sizeof(double))) = 0.009618176115429106;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * (nint)sizeof(double))) = 0.0013333564314950786;
			llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = num11 * num11;
			llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = fputil_multiply_add_double_double_double.Invoke(num11, *(double*)(&inlineArray5_Double), 1.0);
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double_double_double.Invoke(num11, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = fputil_multiply_add_double_double_double.Invoke(num11, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &x5);
			x5 = fputil_multiply_add_double_double_double.Invoke(num14, y, z);
			result = (float)fputil_multiply_add_double_double_double.Invoke(x5, num14 * num13, num15 * num13);
			llvm_lifetime_end_p0.Invoke(8L, &x5);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &num15);
			llvm_lifetime_end_p0.Invoke(8L, &num14);
			llvm_lifetime_end_p0.Invoke(40L, &inlineArray5_Double);
			llvm_lifetime_end_p0.Invoke(8L, &num13);
			llvm_lifetime_end_p0.Invoke(8L, &x4);
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(4L, &num10);
			llvm_lifetime_end_p0.Invoke(4L, &num9);
			goto IL_0a33;
		}
		IL_0285:
		llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
		llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
		unchecked
		{
			*(double*)(&inlineArray6_Double) = 0.6931471805599457;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = 0.24022650695910017;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 0.05550410865673368;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = 0.009618129109319968;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 0.0013333780803242515;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = 0.00015403527055187592;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = x;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num6 * num6;
			llvm_lifetime_start_p0.Invoke(8L, &a);
			a = fputil_multiply_add_double_double_double.Invoke(num6, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num6, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num6, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x2, a, a_yc74sk, a_ijazrn);
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = fputil_multiply_add_double_double_double.Invoke(x3, num6, 1.0);
			result = (float)num7;
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			goto IL_0a33;
		}
	}
}
