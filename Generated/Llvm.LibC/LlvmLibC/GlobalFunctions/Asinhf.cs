using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Asinhf
{
	[MangledName("asinhf")]
	[DemangledName("asinhf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		double num3 = 0.0;
		double x = 0.0;
		double y = 0.0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		double num4 = 0.0;
		double num5 = 0.0;
		Anon_prxz47 anon_prxz = default(Anon_prxz47);
		Anon_prxz47 anon_prxz2 = default(Anon_prxz47);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float result;
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num6 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			num2 = num6;
			if (Details_expects_bool_condition_bool.Invoke((uint)num2 <= 1048576000u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num2 <= 847249408u, Expected: false))
				{
					result = (float)((!Details_expects_bool_condition_bool.Invoke(num2 == 0, Expected: false)) ? Llvm_fmuladd_f64.Invoke(0.0 - 1.0 / 6.0 * (double)X * (double)X, X, X) : ((double)X));
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = X;
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = num3 * num3;
					Llvm_lifetime_start_p0.Invoke(8L, &y);
					y = Fputil_polyeval_double_double_double_double_double_double_double_double_double.Invoke(x, 0.0, -0.16666666666666513, 0.0749999999992091, -0.04464285700277445, 0.030381932398349652, -0.02237158380794454, 0.01733666828653077, -0.013701017976386036, 0.009171248604625254);
					result = (float)Fputil_multiply_add_double.Invoke(num3, y, num3);
					Llvm_lifetime_end_p0.Invoke(8L, &y);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
				goto IL_0500;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (nint)(uint)(num >>> 31) * (nint)sizeof(double)));
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = X;
			Llvm_lifetime_start_p0.Invoke(8L, &anon_prxz);
			*(double*)(&anon_prxz) = double.NaN;
			anon_prxz.field_0 = num4;
			Llvm_lifetime_start_p0.Invoke(8L, &anon_prxz2);
			*(double*)(&anon_prxz2) = double.NaN;
			anon_prxz2.field_0 = num4;
			if (Details_expects_bool_condition_bool.Invoke((uint)num2 >= 1272800677u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)), Expected: false))
				{
					result = X;
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
													result = _1_Invoke_9pzp2z.Invoke(&anon_prxz2, 81.26974f);
												}
												else
												{
													result = _0_Invoke_i9dnz4.Invoke(&anon_prxz, 66.17683f);
												}
											}
											else
											{
												result = _1_Invoke_9pzp2z.Invoke(&anon_prxz2, 53.92517f);
											}
										}
										else
										{
											result = _0_Invoke_i9dnz4.Invoke(&anon_prxz, 53.20505f);
										}
									}
									else
									{
										result = _1_Invoke_9pzp2z.Invoke(&anon_prxz2, 43.57239f);
									}
								}
								else
								{
									result = _1_Invoke_9pzp2z.Invoke(&anon_prxz2, 40.71937f);
								}
							}
							else
							{
								result = _1_Invoke_9pzp2z.Invoke(&anon_prxz2, 22.991505f);
							}
						}
						else
						{
							result = _0_Invoke_i9dnz4.Invoke(&anon_prxz, 18.7169f);
						}
					}
					else
					{
						result = _0_Invoke_i9dnz4.Invoke(&anon_prxz, 17.876608f);
					}
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke(num2 == 1168879398, Expected: false))
			{
				result = _0_Invoke_i9dnz4.Invoke(&anon_prxz, 9.30454f);
			}
			else
			{
				if (!Details_expects_bool_condition_bool.Invoke(num2 == 1238536264, Expected: false))
				{
					goto IL_0482;
				}
				result = _0_Invoke_i9dnz4.Invoke(&anon_prxz, 15.053848f);
			}
			goto IL_04ae;
		}
		IL_0482:
		result = (float)(num4 * Llvm_libc_20_1_2_log_eval_xbkv4j.Invoke(Fputil_multiply_add_double.Invoke(num5, num4, Fputil_sqrt_double_double.Invoke(Fputil_multiply_add_double.Invoke(num5, num5, 1.0)))));
		goto IL_04ae;
		IL_04ae:
		Llvm_lifetime_end_p0.Invoke(8L, &anon_prxz2);
		Llvm_lifetime_end_p0.Invoke(8L, &anon_prxz);
		Llvm_lifetime_end_p0.Invoke(8L, &num5);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
		goto IL_0500;
		IL_0500:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
	}
}
