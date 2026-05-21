using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_sincospif16_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_16sincospif16_evalEfRfS0_S0_S0_")]
	[DemangledName("__llvm_libc_20_1_2_::sincospif16_eval(float, float&, float&, float&, float&)")]
	public unsafe static void Invoke([MangledName("xf")][NativeType("float")] float Xf, [MangledName("sin_k")][NativeType("float&")] void* Sin_k, [MangledName("cos_k")][NativeType("float&")] void* Cos_k, [MangledName("sin_y")][NativeType("float&")] void* Sin_y, [MangledName("cosm1_y")][NativeType("float&")] void* Cosm1_y)
	{
		float y = 0f;
		int k = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &y);
		y = float.NaN;
		Llvm_lifetime_start_p0.Invoke(4L, &k);
		k = Llvm_libc_20_1_2_range_reduction_sincospif16.Invoke(Xf, &y);
		Llvm_libc_20_1_2_sincosf16_poly_eval_xs7xs2.Invoke(k, y, Sin_k, Cos_k, Sin_y, Cosm1_y);
		Llvm_lifetime_end_p0.Invoke(4L, &k);
		Llvm_lifetime_end_p0.Invoke(4L, &y);
	}
}
