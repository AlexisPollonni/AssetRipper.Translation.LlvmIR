using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_16sincospif16_evalEfRfS0_S0_S0_")]
[DemangledName("__llvm_libc_20_1_2_::sincospif16_eval(float, float&, float&, float&, float&)")]
internal static partial class sincospif16_eval_float_float_float_float_float
{
	public unsafe static void Invoke(float xf, void* sin_k, void* cos_k, void* sin_y, void* cosm1_y)
	{
		float y = 0f;
		int k = 0;
		llvm_lifetime_start_p0.Invoke(4L, &y);
		y = float.NaN;
		llvm_lifetime_start_p0.Invoke(4L, &k);
		k = range_reduction_sincospif16_float_float.Invoke(xf, &y);
		sincosf16_poly_eval_int_float_float_float_float_float.Invoke(k, y, sin_k, cos_k, sin_y, cosm1_y);
		llvm_lifetime_end_p0.Invoke(4L, &k);
		llvm_lifetime_end_p0.Invoke(4L, &y);
	}
}
