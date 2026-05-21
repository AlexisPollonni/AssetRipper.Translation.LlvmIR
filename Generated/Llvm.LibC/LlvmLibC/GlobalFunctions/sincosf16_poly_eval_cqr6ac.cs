using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sincosf16_poly_eval_cqr6ac
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L19sincosf16_poly_evalEifRfS0_S0_S0_.3")]
	[DemangledName("__llvm_libc_20_1_2_::sincosf16_poly_eval(int, float, float&, float&, float&, float&) (.3)")]
	[CleanName("sincosf16_poly_eval")]
	public unsafe static void Invoke([NativeType("int")] int k, [NativeType("float")] float y, [NativeType("float&")] void* sin_k, [NativeType("float&")] void* cos_k, [NativeType("float&")] void* sin_y, [NativeType("float&")] void* cosm1_y)
	{
		float num = 0f;
		unchecked
		{
			*(float*)sin_k = ((float*)SIN_K_PI_OVER_32_4.Pointer)[k & 0x3F];
			long num2 = checked(k + 16) & 0x3F;
			*(float*)cos_k = ((float*)SIN_K_PI_OVER_32_4.Pointer)[num2];
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = y * y;
			*(float*)sin_y = y * fputil_polyeval_float_float_float_float.Invoke(num, (float)Math.PI / 32f, -0.00015779349f, 7.7523384E-07f, -1.5981906E-06f);
			*(float*)cosm1_y = num * fputil_polyeval_float_float_float.Invoke(num, -0.0048191426f, 3.869069E-06f, 3.0774923E-09f);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
