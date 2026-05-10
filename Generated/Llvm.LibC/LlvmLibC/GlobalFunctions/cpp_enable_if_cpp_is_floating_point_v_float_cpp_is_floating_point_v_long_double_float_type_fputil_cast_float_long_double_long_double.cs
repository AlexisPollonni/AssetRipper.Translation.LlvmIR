using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIfeEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<long double>, float>::type __llvm_libc_20_1_2_::fputil::cast<float, long double>(long double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_long_double_float_type_fputil_cast_float_long_double_long_double
{
	public static float Invoke(double x)
	{
		return (float)x;
	}
}
