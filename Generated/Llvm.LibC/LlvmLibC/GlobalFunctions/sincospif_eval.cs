using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sincospif_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14sincospif_evalEdRdS0_S0_S0_")]
	[DemangledName("__llvm_libc_20_1_2_::sincospif_eval(double, double&, double&, double&, double&)")]
	public unsafe static void Invoke([NativeType("double")] double xd, [NativeType("double&")] void* sin_k, [NativeType("double&")] void* cos_k, [NativeType("double&")] void* sin_y, [NativeType("double&")] void* cosm1_y)
	{
		double y = 0.0;
		long k = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = double.NaN;
		llvm_lifetime_start_p0.Invoke(8L, &k);
		k = range_reduction_sincospi.Invoke(xd, &y);
		sincosf_poly_eval_kyp6bv.Invoke(k, y, sin_k, cos_k, sin_y, cosm1_y);
		llvm_lifetime_end_p0.Invoke(8L, &k);
		llvm_lifetime_end_p0.Invoke(8L, &y);
	}
}
