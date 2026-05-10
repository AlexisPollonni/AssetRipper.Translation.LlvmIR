using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class log10f
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
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		int num4 = 0;
		float num5 = 0f;
		double num6 = 0.0;
		InlineArray5_Double inlineArray5_Double = default(InlineArray5_Double);
		double x2 = 0.0;
		double a_ijazrn = 0.0;
		double a_yc74sk = 0.0;
		double a = 0.0;
		double num7 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0.3010299956639812;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		*unchecked((int*)(&fputil_FPBits_5nkvcs2)) = -1431655766;
		fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs2);
		float result;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num2 & 0x3FF) == 0, expected: false))
		{
			int num8 = num2;
			if (num8 != 1065353216)
			{
				if (num8 != 1092616192)
				{
					if (num8 != 1120403456)
					{
						if (num8 != 1148846080)
						{
							if (num8 != 1176256512)
							{
								if (num8 != 1203982336)
								{
									if (num8 != 1232348160)
									{
										goto IL_0263;
									}
									result = 6f;
								}
								else
								{
									result = 5f;
								}
							}
							else
							{
								result = 4f;
							}
						}
						else
						{
							result = 3f;
						}
					}
					else
					{
						result = 2f;
					}
				}
				else
				{
					result = 1f;
				}
			}
			else
			{
				result = 0f;
			}
		}
		else
		{
			int num9 = num2;
			if (num9 != 1259902592)
			{
				if (num9 != 1287568416)
				{
					if (num9 != 1315859240)
					{
						if (num9 != 1343554297)
						{
							if (num9 != 251588218)
							{
								if (num9 != 1063247387)
								{
									if (num9 != 1065382104)
									{
										goto IL_0263;
									}
									result = float_fputil_round_result_slightly_up_float_float.Invoke(0.0014930184f);
								}
								else
								{
									result = float_fputil_round_result_slightly_up_float_float.Invoke(-0.058248725f);
								}
							}
							else
							{
								result = float_fputil_round_result_slightly_up_float_float.Invoke(-29.201727f);
							}
						}
						else
						{
							result = 10f;
						}
					}
					else
					{
						result = 9f;
					}
				}
				else
				{
					result = 8f;
				}
			}
			else
			{
				result = 7f;
			}
		}
		goto IL_0786;
		IL_0774:
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0786;
		IL_0263:
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = -127;
		int num10 = num2;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
		int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_normal_Sign.Invoke(anon_izyfb8.val);
		fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
		unchecked
		{
			bool num11 = (uint)num10 < (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs3);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			int value;
			if (num11)
			{
				value = -1;
			}
			else
			{
				int num12 = num2;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal_Sign.Invoke(anon_izyfb9.val);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				value = (((uint)num12 > (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs4)) ? 1 : 0);
			}
			bool num13 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((byte)value != 0, expected: false);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			if (!num13)
			{
				goto IL_04db;
			}
		}
		if (x == 0f)
		{
			fputil_set_errno_if_required_int.Invoke(34);
			fputil_raise_except_if_required_int.Invoke(4);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_NEG.Pointer, 1L, isVolatile: false);
			int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb10.val);
			fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
			result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
		}
		else if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke(&fputil_FPBits_5nkvcs2) && !fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
		{
			fputil_set_errno_if_required_int.Invoke(33);
			fputil_raise_except_if_required_int.Invoke(1);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
			int field_4 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb11.val, 0);
			fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
			result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
		}
		else
		{
			if (!fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs7, fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2) * 8388608f);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs7, 4L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				num3 -= 23;
				num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs2);
				goto IL_04db;
			}
			result = x;
		}
		goto IL_0774;
		IL_0786:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
		IL_04db:
		num3 += num2 >>> 23;
		llvm_lifetime_start_p0.Invoke(4L, &num4);
		num4 = (num2 >>> 16) & 0x7F;
		fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, 127);
		llvm_lifetime_start_p0.Invoke(4L, &num5);
		num5 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = double.NaN;
		float x3 = num5;
		long num14 = num4;
		unchecked
		{
			num6 = fputil_multiply_add_float_float_float.Invoke(x3, ((float*)R.Pointer)[num14], -1f);
			llvm_lifetime_start_p0.Invoke(40L, &inlineArray5_Double);
			llvm_memset_p0_i64.Invoke(&inlineArray5_Double, 0, 40L, isVolatile: false);
			*(double*)(&inlineArray5_Double) = 0.4342944819032211;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))) = -0.2171472409551444;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * (nint)sizeof(double))) = 0.14476484000040593;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * (nint)sizeof(double))) = -0.10857397705104328;
			Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * (nint)sizeof(double))) = 0.08615864777352002;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num6 * num6;
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num6, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num6, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a);
			double x4 = num6;
			double y = *(double*)(&inlineArray5_Double);
			long num15 = num4;
			a = fputil_multiply_add_double_double_double.Invoke(x4, y, ((double*)LOG10_R.Pointer)[num15]);
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = fputil_multiply_add_double_double_double.Invoke(num3, 0.3010299956639812, cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x2, a, a_yc74sk, a_ijazrn));
			result = (float)num7;
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(40L, &inlineArray5_Double);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			goto IL_0774;
		}
	}
}
