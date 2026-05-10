using System;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIDF16_fEET_T0_S3_S3_")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fma<_Float16, float>(float, float, float)")]
internal static partial class Float16_fputil_fma_Float16_float_float_float_float
{
	public static Half Invoke(float x, float y, float z)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_sizeof_Float16_sizeof_float_Float16_type_fputil_generic_fma_Float16_float_float_float_float.Invoke(x, y, z);
	}
}
