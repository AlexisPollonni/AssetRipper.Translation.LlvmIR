using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_113poly_approx_dEd.39")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::poly_approx_d(double) (.39)")]
internal static partial class anonymous_namespace_poly_approx_d_double_39
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
		z = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(dx, 0.2402265069591007, 0.6931471805599453);
		llvm_lifetime_start_p0.Invoke(8L, &y);
		y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(dx, 0.009618130735515667, 0.05550411075639526);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, y, z);
		double result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &y);
		llvm_lifetime_end_p0.Invoke(8L, &z);
		llvm_lifetime_end_p0.Invoke(8L, &x);
		return result;
	}
}
