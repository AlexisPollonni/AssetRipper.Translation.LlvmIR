using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class logf
{
	public unsafe static float Invoke(float x)
	{
		double num = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num2 = 0;
		int num3 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		int num4 = 0;
		int num5 = 0;
		float num6 = 0f;
		double num7 = 0.0;
		InlineArray4_Double inlineArray4_Double = default(InlineArray4_Double);
		double x2 = 0.0;
		double a_ijazrn = 0.0;
		double a_yc74sk = 0.0;
		double a = 0.0;
		double num8 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0.6931471805599453;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		float result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = -127;
			if ((uint)num2 < 1281189285u)
			{
				int num9 = num2;
				if (num9 != 1065307503)
				{
					if (num9 != 1092063211)
					{
						if (num9 != 1065353216)
						{
							int num10 = num2;
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_normal_Sign.Invoke(anon_izyfb8.val);
							fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
							bool num11 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num10 < (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)), expected: false);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
							if (num11)
							{
								if (x == 0f)
								{
									fputil_set_errno_if_required_int.Invoke(34);
									fputil_raise_except_if_required_int.Invoke(4);
									llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
									llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_NEG.Pointer, 1L, isVolatile: false);
									int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb9.val);
									fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
									result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
									llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
									goto IL_0780;
								}
								llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
								fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs5, fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2) * 8388608f);
								llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
								llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
								num3 = checked(num3 - 23);
								num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
							}
							goto IL_04e7;
						}
						result = 0f;
					}
					else
					{
						result = float_fputil_round_result_slightly_up_float_float.Invoke(2.2484071f);
					}
				}
				else
				{
					result = float_fputil_round_result_slightly_up_float_float.Invoke(-0.002728426f);
				}
			}
			else
			{
				int num12 = num2;
				if (num12 != 1281189285)
				{
					if (num12 != 1708691667)
					{
						if (num12 != 1865525484)
						{
							if (num12 == 2048389898)
							{
								result = float_fputil_round_result_slightly_up_float_float.Invoke(81.26974f);
							}
							else
							{
								int num13 = num2;
								llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
								int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal_Sign.Invoke(anon_izyfb10.val);
								fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
								bool num14 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num13 > (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs6)), expected: false);
								llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
								if (!num14)
								{
									goto IL_04e7;
								}
								if (num2 == int.MinValue)
								{
									fputil_set_errno_if_required_int.Invoke(34);
									fputil_raise_except_if_required_int.Invoke(4);
									llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
									llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_NEG.Pointer, 1L, isVolatile: false);
									int field_4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb11.val);
									fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
									result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs7);
									llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
								}
								else if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) && !fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
								{
									fputil_set_errno_if_required_int.Invoke(33);
									fputil_raise_except_if_required_int.Invoke(1);
									llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
									llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
									int field_5 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb12.val, 0);
									fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
									result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs8);
									llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
								}
								else
								{
									result = x;
								}
							}
						}
						else
						{
							result = float_fputil_round_result_slightly_down_float_float.Invoke(66.17683f);
						}
					}
					else
					{
						result = float_fputil_round_result_slightly_down_float_float.Invoke(53.20505f);
					}
				}
				else
				{
					result = float_fputil_round_result_slightly_down_float_float.Invoke(17.876608f);
				}
			}
			goto IL_0780;
		}
		IL_04e7:
		llvm_lifetime_start_p0.Invoke(4L, &num4);
		num4 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke(unchecked((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)));
		llvm_lifetime_start_p0.Invoke(4L, &num5);
		num5 = num4 >>> 16;
		num3 += unchecked(num2 + 65536) >>> 23;
		unchecked
		{
			fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2), 127);
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = double.NaN;
			float x3 = num6;
			long num15 = num5;
			num7 = fputil_multiply_add_float_float_float.Invoke(x3, ((float*)R.Pointer)[num15], -1f);
			llvm_lifetime_start_p0.Invoke(32L, &inlineArray4_Double);
			*(double*)(&inlineArray4_Double) = -0.5000000000072301;
			((double*)(&inlineArray4_Double))[1] = 0.33333335685250753;
			((double*)(&inlineArray4_Double))[2L] = -0.25000060901938814;
			((double*)(&inlineArray4_Double))[3L] = 0.19843770376911582;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num7 * num7;
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num7, Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, (nint)2 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num7, Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, sizeof(double))), *(double*)(&inlineArray4_Double));
			llvm_lifetime_start_p0.Invoke(8L, &a);
			long num16 = num5;
			a = ((double*)LOG_R.Pointer)[num16] + num7;
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = fputil_multiply_add_double_double_double.Invoke(num3, 0.6931471805599453, cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x2, a, a_yc74sk, a_ijazrn));
			result = (float)num8;
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(32L, &inlineArray4_Double);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			goto IL_0780;
		}
		IL_0780:
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
