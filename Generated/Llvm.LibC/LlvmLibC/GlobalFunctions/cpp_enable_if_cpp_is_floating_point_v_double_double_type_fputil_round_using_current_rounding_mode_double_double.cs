using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil33round_using_current_rounding_modeIdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type __llvm_libc_20_1_2_::fputil::round_using_current_rounding_mode<double>(double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_round_using_current_rounding_mode_double_double
{
	public unsafe static double Invoke(double x)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = fputil_quick_get_round.Invoke();
		double result = num switch
		{
			1024 => cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_round_using_specific_rounding_mode_double_double_int.Invoke(x, 1), 
			2048 => cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_round_using_specific_rounding_mode_double_double_int.Invoke(x, 0), 
			3072 => cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_round_using_specific_rounding_mode_double_double_int.Invoke(x, 2), 
			0 => cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_round_using_specific_rounding_mode_double_double_int.Invoke(x, 4), 
			_ => throw null, 
		};
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
