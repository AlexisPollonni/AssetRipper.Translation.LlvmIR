using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3addIdgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<__float128> && sizeof (double) <= sizeof (__float128), double>::type __llvm_libc_20_1_2_::fputil::generic::add<double, __float128>(__float128, __float128)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_float128_sizeof_double_sizeof_float128_double_type_fputil_generic_add_double_float128_float128_float128
{
	public static double Invoke(double x, double y)
	{
		return cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_float128_sizeof_double_sizeof_float128_double_type_fputil_generic_add_or_sub_false_double_float128_float128_float128.Invoke(x, y);
	}
}
