using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIdgEET_T0_S3_S3_")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::fma<double, __float128>(__float128, __float128, __float128)")]
internal static partial class double_fputil_fma_double_float128_float128_float128_float128
{
	public static double Invoke(double x, double y, double z)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_float128_sizeof_double_sizeof_float128_double_type_fputil_generic_fma_double_float128_float128_float128_float128.Invoke(x, y, z);
	}
}
