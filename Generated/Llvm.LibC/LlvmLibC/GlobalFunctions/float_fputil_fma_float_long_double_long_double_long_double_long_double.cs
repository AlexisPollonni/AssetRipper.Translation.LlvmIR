using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIfeEET_T0_S3_S3_")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, long double>(long double, long double, long double)")]
internal static partial class float_fputil_fma_float_long_double_long_double_long_double_long_double
{
	public static float Invoke(double x, double y, double z)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_long_double_sizeof_float_sizeof_long_double_float_type_fputil_generic_fma_float_long_double_long_double_long_double_long_double.Invoke(x, y, z);
	}
}
