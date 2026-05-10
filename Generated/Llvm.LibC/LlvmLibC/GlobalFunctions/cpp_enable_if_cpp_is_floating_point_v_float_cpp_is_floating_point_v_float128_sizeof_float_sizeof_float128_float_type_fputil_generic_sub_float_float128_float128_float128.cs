using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3subIfgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<__float128> && sizeof (float) <= sizeof (__float128), float>::type __llvm_libc_20_1_2_::fputil::generic::sub<float, __float128>(__float128, __float128)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float128_sizeof_float_sizeof_float128_float_type_fputil_generic_sub_float_float128_float128_float128
{
	public static float Invoke(double x, double y)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float128_sizeof_float_sizeof_float128_float_type_fputil_generic_add_or_sub_true_float_float128_float128_float128.Invoke(x, y);
	}
}
