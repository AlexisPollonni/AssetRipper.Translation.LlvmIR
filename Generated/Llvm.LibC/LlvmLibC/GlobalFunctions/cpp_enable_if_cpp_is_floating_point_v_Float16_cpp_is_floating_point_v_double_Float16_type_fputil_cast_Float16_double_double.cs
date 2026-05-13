using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIDF16_dEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double>, _Float16>::type __llvm_libc_20_1_2_::fputil::cast<_Float16, double>(double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_double_Float16_type_fputil_cast_Float16_double_double
{
	public static Half Invoke(double x)
	{
		return unchecked((Half)x);
	}
}
