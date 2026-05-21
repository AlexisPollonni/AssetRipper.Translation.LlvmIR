using System.Runtime.CompilerServices;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class asinhf
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		double num3 = 0.0;
		double x2 = 0.0;
		double y = 0.0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		double num4 = 0.0;
		double num5 = 0.0;
		anon_prxz47 anon_prxz48 = default(anon_prxz47);
		anon_prxz47 anon_prxz49 = default(anon_prxz47);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		float result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num6 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			num2 = num6;
			if (details_expects_bool_condition_bool.Invoke((uint)num2 <= 1048576000u, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((uint)num2 <= 847249408u, expected: false))
				{
					result = (float)((!details_expects_bool_condition_bool.Invoke(num2 == 0, expected: false)) ? llvm_fmuladd_f64.Invoke(0.0 - 1.0 / 6.0 * (double)x * (double)x, x, x) : ((double)x));
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = x;
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num3 * num3;
					llvm_lifetime_start_p0.Invoke(8L, &y);
					y = fputil_polyeval_double_double_double_double_double_double_double_double_double.Invoke(x2, 0.0, -0.16666666666666513, 0.0749999999992091, -0.04464285700277445, 0.030381932398349652, -0.02237158380794454, 0.01733666828653077, -0.013701017976386036, 0.009171248604625254);
					result = (float)fputil_multiply_add_double.Invoke(num3, y, num3);
					llvm_lifetime_end_p0.Invoke(8L, &y);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
					llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
				goto IL_0500;
			}
			llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (nint)(uint)(num >>> 31) * (nint)sizeof(double)));
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = x;
			llvm_lifetime_start_p0.Invoke(8L, &anon_prxz48);
			*(double*)(&anon_prxz48) = double.NaN;
			anon_prxz48.field_0 = num4;
			llvm_lifetime_start_p0.Invoke(8L, &anon_prxz49);
			*(double*)(&anon_prxz49) = double.NaN;
			anon_prxz49.field_0 = num4;
			if (details_expects_bool_condition_bool.Invoke((uint)num2 >= 1272800677u, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), expected: false))
				{
					result = x;
				}
				else
				{
					int num7 = num2;
					if (num7 != 1272800677)
					{
						if (num7 != 1283473196)
						{
							if (num7 != 1334835971)
							{
								if (num7 != 1549180552)
								{
									if (num7 != 1583913038)
									{
										if (num7 != 1700303059)
										{
											if (num7 != 1709079718)
											{
												if (num7 != 1857136876)
												{
													if (num7 != 2040001290)
													{
														goto IL_0482;
													}
													result = _1_Invoke_9pzp2z.Invoke(&anon_prxz49, 81.26974f);
												}
												else
												{
													result = _0_Invoke_i9dnz4.Invoke(&anon_prxz48, 66.17683f);
												}
											}
											else
											{
												result = _1_Invoke_9pzp2z.Invoke(&anon_prxz49, 53.92517f);
											}
										}
										else
										{
											result = _0_Invoke_i9dnz4.Invoke(&anon_prxz48, 53.20505f);
										}
									}
									else
									{
										result = _1_Invoke_9pzp2z.Invoke(&anon_prxz49, 43.57239f);
									}
								}
								else
								{
									result = _1_Invoke_9pzp2z.Invoke(&anon_prxz49, 40.71937f);
								}
							}
							else
							{
								result = _1_Invoke_9pzp2z.Invoke(&anon_prxz49, 22.991505f);
							}
						}
						else
						{
							result = _0_Invoke_i9dnz4.Invoke(&anon_prxz48, 18.7169f);
						}
					}
					else
					{
						result = _0_Invoke_i9dnz4.Invoke(&anon_prxz48, 17.876608f);
					}
				}
			}
			else if (details_expects_bool_condition_bool.Invoke(num2 == 1168879398, expected: false))
			{
				result = _0_Invoke_i9dnz4.Invoke(&anon_prxz48, 9.30454f);
			}
			else
			{
				if (!details_expects_bool_condition_bool.Invoke(num2 == 1238536264, expected: false))
				{
					goto IL_0482;
				}
				result = _0_Invoke_i9dnz4.Invoke(&anon_prxz48, 15.053848f);
			}
			goto IL_04ae;
		}
		IL_0482:
		result = (float)(num4 * log_eval_xbkv4j.Invoke(fputil_multiply_add_double.Invoke(num5, num4, fputil_sqrt_double_double.Invoke(fputil_multiply_add_double.Invoke(num5, num5, 1.0)))));
		goto IL_04ae;
		IL_04ae:
		llvm_lifetime_end_p0.Invoke(8L, &anon_prxz49);
		llvm_lifetime_end_p0.Invoke(8L, &anon_prxz48);
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
		goto IL_0500;
		IL_0500:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}
