using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIfgEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<__float128>, float>::type __llvm_libc_20_1_2_::fputil::cast<float, __float128>(__float128)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float128_float_type_fputil_cast_float_float128_float128
{
	public static float Invoke(double x)
	{
		return (float)x;
	}
}
