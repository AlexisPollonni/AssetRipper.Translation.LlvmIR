using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_poly_approx_d_twxp8v
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_113poly_approx_dEd.45")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::poly_approx_d(double) (.45)")]
	[CleanName("anonymous_namespace_poly_approx_d")]
	public unsafe static double Invoke([NativeType("double")] double dx)
	{
		double x = 0.0;
		double z = 0.0;
		double y = 0.0;
		double num = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &x);
		x = dx * dx;
		llvm_lifetime_start_p0.Invoke(8L, &z);
		z = fputil_multiply_add_double.Invoke(dx, 2.6509490552391997, 2.302585092994046);
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = fputil_multiply_add_double.Invoke(dx, 1.1712549195360904, 2.0346785162735497);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = fputil_multiply_add_double.Invoke(x, y, z);
		double result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &y);
		llvm_lifetime_end_p0.Invoke(8L, &z);
		llvm_lifetime_end_p0.Invoke(8L, &x);
		return result;
	}
}
