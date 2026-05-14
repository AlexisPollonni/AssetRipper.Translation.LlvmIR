using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIddEET_T0_S3_S3_")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::fma<double, double>(double, double, double)")]
internal static partial class double_fputil_fma_double_double_double_double_double
{
	public static double Invoke(double x, double y, double z)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_double_sizeof_double_sizeof_double_double_type_fputil_generic_fma_double_double_double_double_double.Invoke(x, y, z);
	}
}
