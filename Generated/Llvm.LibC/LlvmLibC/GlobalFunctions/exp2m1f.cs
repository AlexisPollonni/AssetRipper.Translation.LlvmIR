using System;
using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exp2m1f
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		cpp_optional_89h55j cpp_optional_89h55j2 = default(cpp_optional_89h55j);
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double num3 = 0.0;
		double x2 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double num4 = 0.0;
		int num5 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num6 = 0;
		cpp_optional_89h55j cpp_optional_89h55j3 = default(cpp_optional_89h55j);
		float num7 = 0f;
		int num8 = 0;
		double num9 = 0.0;
		long num10 = 0L;
		long x3 = 0L;
		double y = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		InlineArray5_Double inlineArray5_Double = default(InlineArray5_Double);
		double x4 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double a_ijazrn2 = 0.0;
		double x5 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(((uint)num2 < 1124073472u) ? ((uint)num2 <= 1023410176u) : true, expected: false))
			{
				goto IL_05a4;
			}
			if ((uint)num2 <= 1023410176u)
			{
				llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_89h55j2);
				sbyte* ptr = (sbyte*)(&cpp_optional_89h55j2);
				*(float*)ptr = float.NaN;
				ptr[4] = -86;
				sbyte* ptr2 = ptr + 5;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				long storage = fputil_ExceptValues_float_8ul_lookup_unsigned_int_const.Invoke(x_bits: num, @this: EXP2M1F_EXCEPTS_LO.Pointer);
				*(long*)(&cpp_optional_89h55j2.storage) = storage;
				int num11;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_float_has_value_const.Invoke(&cpp_optional_89h55j2), expected: false))
				{
					result = *(float*)cpp_optional_float_value.Invoke(&cpp_optional_89h55j2);
					num11 = 1;
				}
				else
				{
					num11 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_89h55j2);
				switch (num11)
				{
				case 0:
					llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
					llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
					*(double*)(&inlineArray6_Double) = 0.6931471805599457;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = 0.24022650695910017;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 0.05550410865673368;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = 0.009618129109319968;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 0.0013333780803242515;
					Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = 0.00015403527055187592;
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = x;
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num3 * num3;
					llvm_lifetime_start_p0.Invoke(8L, &a);
					a = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
					llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
					a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
					llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
					a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x2, a, a_yc74sk, a_ijazrn);
					result = (float)(num4 * num3);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
					llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
					llvm_lifetime_end_p0.Invoke(8L, &a);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
					llvm_lifetime_end_p0.Invoke(8L, &num3);
					llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
					break;
				}
			}
			else
			{
				if (!fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
				{
					goto IL_05a4;
				}
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_finite_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = fputil_quick_get_round.Invoke();
					int num11;
					if (num5 == 1024 || num5 == 3072)
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal_Sign.Invoke(anon_izyfb8.val);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						num11 = 1;
					}
					else
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(8);
						num11 = 0;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					switch (num11)
					{
					case 0:
						break;
					default:
						goto IL_0a24;
					}
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb9.val);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				result = x + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			}
			goto IL_0a24;
		}
		IL_0a24:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
		IL_05a4:
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(!(x > -25f), expected: false))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = -1f;
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = x;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = fputil_quick_get_round.Invoke();
					if (num6 == 2048 || num6 == 3072)
					{
						result = (float)Math.PI * -113f / 355f;
					}
					else
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(16);
						result = -1f;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_89h55j3);
				sbyte* ptr3 = (sbyte*)(&cpp_optional_89h55j3);
				*(float*)ptr3 = float.NaN;
				ptr3[4] = -86;
				sbyte* ptr4 = ptr3 + 5;
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				long storage2 = fputil_ExceptValues_float_3ul_lookup_unsigned_int_const.Invoke(x_bits: num, @this: EXP2M1F_EXCEPTS_HI.Pointer);
				*(long*)(&cpp_optional_89h55j3.storage) = storage2;
				int num11;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_float_has_value_const.Invoke(&cpp_optional_89h55j3), expected: false))
				{
					result = *(float*)cpp_optional_float_value.Invoke(&cpp_optional_89h55j3);
					num11 = 1;
				}
				else
				{
					num11 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_89h55j3);
				switch (num11)
				{
				case 0:
				{
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = -1431655766;
					num7 = fputil_nearest_integer_float.Invoke(x * 32f);
					num8 = (int)num7;
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = fputil_multiply_add_float_float_float.Invoke(-1f / 32f, num7, x);
					llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = (long)(num8 >> 5) << 52;
					llvm_lifetime_start_p0.Invoke(8L, &x3);
					long num12 = num8 & 0x1F;
					checked
					{
						x3 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num12] + num10;
						llvm_lifetime_start_p0.Invoke(8L, &y);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x3);
						double num13 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						y = num13;
						llvm_lifetime_start_p0.Invoke(40L, &inlineArray5_Double);
						llvm_memset_p0_i64.Invoke(&inlineArray5_Double, 0, 40L, isVolatile: false);
					}
					*(double*)(&inlineArray5_Double) = 0.6931471805599453;
					Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))) = 0.2402265069562316;
					Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * (nint)sizeof(double))) = 0.05550410866548564;
					Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * (nint)sizeof(double))) = 0.009618176115429106;
					Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * (nint)sizeof(double))) = 0.0013333564314950786;
					llvm_lifetime_start_p0.Invoke(8L, &x4);
					x4 = num9 * num9;
					llvm_lifetime_start_p0.Invoke(8L, &a2);
					a2 = fputil_multiply_add_double_double_double.Invoke(num9, *(double*)(&inlineArray5_Double), 1.0);
					llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
					a_yc74sk2 = fputil_multiply_add_double_double_double.Invoke(num9, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))));
					llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn2);
					a_ijazrn2 = fputil_multiply_add_double_double_double.Invoke(num9, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * sizeof(double))));
					llvm_lifetime_start_p0.Invoke(8L, &x5);
					x5 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x4, a2, a_yc74sk2, a_ijazrn2);
					result = (float)fputil_multiply_add_double_double_double.Invoke(x5, y, -1.0);
					llvm_lifetime_end_p0.Invoke(8L, &x5);
					llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn2);
					llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
					llvm_lifetime_end_p0.Invoke(8L, &a2);
					llvm_lifetime_end_p0.Invoke(8L, &x4);
					llvm_lifetime_end_p0.Invoke(40L, &inlineArray5_Double);
					llvm_lifetime_end_p0.Invoke(8L, &y);
					llvm_lifetime_end_p0.Invoke(8L, &x3);
					llvm_lifetime_end_p0.Invoke(8L, &num10);
					llvm_lifetime_end_p0.Invoke(8L, &num9);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					break;
				}
				}
			}
			goto IL_0a24;
		}
	}
}
