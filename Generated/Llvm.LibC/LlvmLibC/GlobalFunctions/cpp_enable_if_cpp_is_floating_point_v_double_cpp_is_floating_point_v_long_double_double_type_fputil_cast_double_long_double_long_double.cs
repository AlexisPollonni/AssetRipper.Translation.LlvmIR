using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIdeEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double>, double>::type __llvm_libc_20_1_2_::fputil::cast<double, long double>(long double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_long_double_double_type_fputil_cast_double_long_double_long_double
{
	public static double Invoke(double x)
	{
		return x;
	}
}
