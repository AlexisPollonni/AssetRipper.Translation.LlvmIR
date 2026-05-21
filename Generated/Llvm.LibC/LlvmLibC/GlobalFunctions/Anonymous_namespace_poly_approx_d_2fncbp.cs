using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_poly_approx_d_2fncbp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_113poly_approx_dEd.51")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::poly_approx_d(double) (.51)")]
	[CleanName("Anonymous_namespace_poly_approx_d")]
	public unsafe static double Invoke([MangledName("dx")][NativeType("double")] double Dx)
	{
		double x = 0.0;
		double z = 0.0;
		double y = 0.0;
		double num = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &x);
		x = Dx * Dx;
		Llvm_lifetime_start_p0.Invoke(8L, &z);
		z = Fputil_multiply_add_double.Invoke(Dx, 0.5, 1.0);
		Llvm_lifetime_start_p0.Invoke(8L, &y);
		y = Fputil_multiply_add_double.Invoke(Dx, 1.0 / 24.0, 1.0 / 6.0);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = Fputil_multiply_add_double.Invoke(x, y, z);
		double result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &y);
		Llvm_lifetime_end_p0.Invoke(8L, &z);
		Llvm_lifetime_end_p0.Invoke(8L, &x);
		return result;
	}
}
