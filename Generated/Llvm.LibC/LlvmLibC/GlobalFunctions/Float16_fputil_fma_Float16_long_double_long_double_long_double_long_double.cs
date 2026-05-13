using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIDF16_eEET_T0_S3_S3_")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fma<_Float16, long double>(long double, long double, long double)")]
internal static partial class Float16_fputil_fma_Float16_long_double_long_double_long_double_long_double
{
	public static Half Invoke(double x, double y, double z)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_long_double_sizeof_Float16_sizeof_long_double_Float16_type_fputil_generic_fma_Float16_long_double_long_double_long_double_long_double.Invoke(x, y, z);
	}
}
