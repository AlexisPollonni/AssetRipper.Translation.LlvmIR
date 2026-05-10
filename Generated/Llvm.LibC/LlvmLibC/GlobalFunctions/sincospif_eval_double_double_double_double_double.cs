using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14sincospif_evalEdRdS0_S0_S0_")]
[DemangledName("__llvm_libc_20_1_2_::sincospif_eval(double, double&, double&, double&, double&)")]
internal static partial class sincospif_eval_double_double_double_double_double
{
	public unsafe static void Invoke(double xd, void* sin_k, void* cos_k, void* sin_y, void* cosm1_y)
	{
		double y = 0.0;
		long k = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = double.NaN;
		llvm_lifetime_start_p0.Invoke(8L, &k);
		k = range_reduction_sincospi_double_double.Invoke(xd, &y);
		sincosf_poly_eval_long_double_double_double_double_double_14.Invoke(k, y, sin_k, cos_k, sin_y, cosm1_y);
		llvm_lifetime_end_p0.Invoke(8L, &k);
		llvm_lifetime_end_p0.Invoke(8L, &y);
	}
}
