using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIfgEET_T0_S3_S3_")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, __float128>(__float128, __float128, __float128)")]
internal static partial class float_fputil_fma_float_float128_float128_float128_float128
{
	public static float Invoke(double x, double y, double z)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float128_sizeof_float_sizeof_float128_float_type_fputil_generic_fma_float_float128_float128_float128_float128.Invoke(x, y, z);
	}
}
