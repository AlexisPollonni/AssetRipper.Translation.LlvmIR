using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3subIfdEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type __llvm_libc_20_1_2_::fputil::generic::sub<float, double>(double, double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_double_sizeof_float_sizeof_double_float_type_fputil_generic_sub_float_double_double_double
{
	public static float Invoke(double x, double y)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_double_sizeof_float_sizeof_double_float_type_fputil_generic_add_or_sub_true_float_double_double_double.Invoke(x, y);
	}
}
