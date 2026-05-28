using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sincosf16_poly_eval_xs7xs2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L19sincosf16_poly_evalEifRfS0_S0_S0_")]
	[DemangledName("__llvm_libc_20_1_2_::sincosf16_poly_eval(int, float, float&, float&, float&, float&)")]
	[CleanName("Sincosf16_poly_eval")]
	public unsafe static void Invoke([MangledName("k")][NativeType("int")] int K, [MangledName("y")][NativeType("float")] float Y, [MangledName("sin_k")][NativeType("float&")] void* Sin_k, [MangledName("cos_k")][NativeType("float&")] void* Cos_k, [MangledName("sin_y")][NativeType("float&")] void* Sin_y, [MangledName("cosm1_y")][NativeType("float&")] void* Cosm1_y)
	{
		float num = 0f;
		unchecked
		{
			*(float*)Sin_k = ((float*)SIN_K_PI_OVER_32.Pointer)[K & 0x3F];
			long num2 = checked(K + 16) & 0x3F;
			*(float*)Cos_k = ((float*)SIN_K_PI_OVER_32.Pointer)[num2];
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Y * Y;
			*(float*)Sin_y = Y * Fputil_polyeval_float_float_float_float.Invoke(num, (float)Math.PI / 32f, -0.00015779349f, 7.7523384E-07f, -1.5981906E-06f);
			*(float*)Cosm1_y = num * Fputil_polyeval_float_float_float.Invoke(num, -0.0048191426f, 3.869069E-06f, 3.0774923E-09f);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
