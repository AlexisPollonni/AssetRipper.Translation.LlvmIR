using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_113poly_approx_dEd.51")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::poly_approx_d(double) (.51)")]
internal static partial class anonymous_namespace_poly_approx_d_double_51
{
	public unsafe static double Invoke(double dx)
	{
		double x = 0.0;
		double z = 0.0;
		double y = 0.0;
		double num = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &x);
		x = dx * dx;
		llvm_lifetime_start_p0.Invoke(8L, &z);
		z = fputil_multiply_add_double_double_double.Invoke(dx, 0.5, 1.0);
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = fputil_multiply_add_double_double_double.Invoke(dx, 1.0 / 24.0, 1.0 / 6.0);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = fputil_multiply_add_double_double_double.Invoke(x, y, z);
		double result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &y);
		llvm_lifetime_end_p0.Invoke(8L, &z);
		llvm_lifetime_end_p0.Invoke(8L, &x);
		return result;
	}
}
