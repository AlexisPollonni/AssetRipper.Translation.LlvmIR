using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sincospif_eval
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14sincospif_evalEdRdS0_S0_S0_")]
	[DemangledName("__llvm_libc_20_1_2_::sincospif_eval(double, double&, double&, double&, double&)")]
	public unsafe static void Invoke([MangledName("xd")][NativeType("double")] double Xd, [MangledName("sin_k")][NativeType("double&")] void* Sin_k, [MangledName("cos_k")][NativeType("double&")] void* Cos_k, [MangledName("sin_y")][NativeType("double&")] void* Sin_y, [MangledName("cosm1_y")][NativeType("double&")] void* Cosm1_y)
	{
		double y = 0.0;
		long k = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &y);
		y = double.NaN;
		Llvm_lifetime_start_p0.Invoke(8L, &k);
		k = Range_reduction_sincospi.Invoke(Xd, &y);
		Sincosf_poly_eval_kyp6bv.Invoke(k, y, Sin_k, Cos_k, Sin_y, Cosm1_y);
		Llvm_lifetime_end_p0.Invoke(8L, &k);
		Llvm_lifetime_end_p0.Invoke(8L, &y);
	}
}
