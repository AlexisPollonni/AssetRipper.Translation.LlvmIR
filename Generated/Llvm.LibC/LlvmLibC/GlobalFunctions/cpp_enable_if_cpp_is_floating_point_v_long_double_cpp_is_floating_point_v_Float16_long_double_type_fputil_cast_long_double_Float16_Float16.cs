using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIeDF16_EENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double> && cpp::is_floating_point_v<_Float16>, long double>::type __llvm_libc_20_1_2_::fputil::cast<long double, _Float16>(_Float16)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_long_double_cpp_is_floating_point_v_Float16_long_double_type_fputil_cast_long_double_Float16_Float16
{
	public static double Invoke(Half x)
	{
		return unchecked((double)x);
	}
}
