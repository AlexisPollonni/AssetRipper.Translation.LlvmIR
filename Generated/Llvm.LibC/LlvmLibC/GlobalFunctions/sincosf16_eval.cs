using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sincosf16_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14sincosf16_evalEfRfS0_S0_S0_")]
	[DemangledName("__llvm_libc_20_1_2_::sincosf16_eval(float, float&, float&, float&, float&)")]
	public unsafe static void Invoke([NativeType("float")] float xf, [NativeType("float&")] void* sin_k, [NativeType("float&")] void* cos_k, [NativeType("float&")] void* sin_y, [NativeType("float&")] void* cosm1_y)
	{
		float y = 0f;
		int k = 0;
		llvm_lifetime_start_p0.Invoke(4L, &y);
		y = float.NaN;
		llvm_lifetime_start_p0.Invoke(4L, &k);
		k = range_reduction_sincosf16.Invoke(xf, &y);
		sincosf16_poly_eval_cqr6ac.Invoke(k, y, sin_k, cos_k, sin_y, cosm1_y);
		llvm_lifetime_end_p0.Invoke(4L, &k);
		llvm_lifetime_end_p0.Invoke(4L, &y);
	}
}
