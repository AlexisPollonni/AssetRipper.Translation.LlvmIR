using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Logf
{
	[MangledName("logf")]
	[DemangledName("logf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		double num = 0.0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		int num2 = 0;
		int num3 = 0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		int num4 = 0;
		int num5 = 0;
		float num6 = 0f;
		double num7 = 0.0;
		InlineArray4_Double inlineArray4_Double = default(InlineArray4_Double);
		double x = 0.0;
		double a_ijazrn = 0.0;
		double a_yc74sk = 0.0;
		double a = 0.0;
		double num8 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0.6931471805599453;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		float result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = -127;
			if ((uint)num2 < 1281189285u)
			{
				int num9 = num2;
				if (num9 != 1065307503)
				{
					if (num9 != 1092063211)
					{
						if (num9 != 512247085)
						{
							int num10 = num2;
							Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_normal.Invoke(anon_izyfb.Val);
							fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
							bool num11 = Details_expects_bool_condition_bool.Invoke((uint)num10 < (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), Expected: false);
							Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
							if (num11)
							{
								if (X == 0f)
								{
									Fputil_set_errno_if_required.Invoke(34);
									Fputil_raise_except_if_required.Invoke(4);
									Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
									Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_NEG.Pointer, 1L, isVolatile: false);
									int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
									fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
									result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
									Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
									goto IL_0806;
								}
								Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
								FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs4, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs) * 8388608f);
								Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
								Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
								num3 = checked(num3 - 23);
								num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
							}
							goto IL_0537;
						}
						result = Fputil_round_result_slightly_up_float.Invoke(-45.685104f);
					}
					else
					{
						result = Fputil_round_result_slightly_up_float.Invoke(2.2484071f);
					}
				}
				else
				{
					result = Fputil_round_result_slightly_up_float.Invoke(-0.002728426f);
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
							if (num12 != 2048389898)
							{
								if (num12 != 1343224579)
								{
									if (num12 != 1557569160)
									{
										if (num12 == 1592301646)
										{
											result = Fputil_round_result_slightly_up_float.Invoke(43.57239f);
										}
										else
										{
											int num13 = num2;
											Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
											Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
											int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb3.Val);
											fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
											bool num14 = Details_expects_bool_condition_bool.Invoke((uint)num13 > (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs5)), Expected: false);
											Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
											if (!num14)
											{
												goto IL_0537;
											}
											if (num2 == int.MinValue)
											{
												Fputil_set_errno_if_required.Invoke(34);
												Fputil_raise_except_if_required.Invoke(4);
												Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
												Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_NEG.Pointer, 1L, isVolatile: false);
												int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb4.Val);
												fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
												result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6);
												Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
											}
											else if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) && !FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs))
											{
												Fputil_set_errno_if_required.Invoke(33);
												Fputil_raise_except_if_required.Invoke(1);
												Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
												Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
												int field_5 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb5.Val, 0);
												fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
												result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs7);
												Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
											}
											else
											{
												result = X;
											}
										}
									}
									else
									{
										result = Fputil_round_result_slightly_up_float.Invoke(40.71937f);
									}
								}
								else
								{
									result = Fputil_round_result_slightly_up_float.Invoke(22.991505f);
								}
							}
							else
							{
								result = Fputil_round_result_slightly_up_float.Invoke(81.26974f);
							}
						}
						else
						{
							result = Fputil_round_result_slightly_down_float.Invoke(66.17683f);
						}
					}
					else
					{
						result = Fputil_round_result_slightly_down_float.Invoke(53.20505f);
					}
				}
				else
				{
					result = Fputil_round_result_slightly_down_float.Invoke(17.876608f);
				}
			}
			goto IL_0806;
		}
		IL_0537:
		if (Details_expects_bool_condition_bool.Invoke((num2 & 0x7FFFFF) == 0, Expected: false))
		{
			result = (float)((double)(num3 + unchecked((ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)))) * 0.6931471805599453);
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke(unchecked((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)));
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num4 >>> 16;
			num3 += unchecked(num2 + 65536) >>> 23;
			unchecked
			{
				FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs), 127);
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = double.NaN;
				double x2 = num6;
				long num15 = num5;
				num7 = Fputil_multiply_add_double.Invoke(x2, ((double*)RD.Pointer)[num15], -1.0);
				Llvm_lifetime_start_p0.Invoke(32L, &inlineArray4_Double);
				*(double*)(&inlineArray4_Double) = -0.5000000000072301;
				((double*)(&inlineArray4_Double))[1] = 0.33333335685250753;
				((double*)(&inlineArray4_Double))[2L] = -0.25000060901938814;
				((double*)(&inlineArray4_Double))[3L] = 0.19843770376911582;
				Llvm_lifetime_start_p0.Invoke(8L, &x);
				x = num7 * num7;
				Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
				a_ijazrn = Fputil_multiply_add_double.Invoke(num7, Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, (nint)2 * sizeof(double))));
				Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
				a_yc74sk = Fputil_multiply_add_double.Invoke(num7, Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, sizeof(double))), *(double*)(&inlineArray4_Double));
				Llvm_lifetime_start_p0.Invoke(8L, &a);
				long num16 = num5;
				a = ((double*)LOG_R.Pointer)[num16] + num7;
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = Fputil_multiply_add_double.Invoke(num3, 0.6931471805599453, Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn));
				result = (float)num8;
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &a);
				Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
				Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
				Llvm_lifetime_end_p0.Invoke(8L, &x);
				Llvm_lifetime_end_p0.Invoke(32L, &inlineArray4_Double);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
			}
		}
		goto IL_0806;
		IL_0806:
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
