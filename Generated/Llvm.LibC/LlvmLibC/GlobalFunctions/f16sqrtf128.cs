using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class f16sqrtf128
{
	public static Half Invoke(double x)
	{
		return cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float128_sizeof_Float16_sizeof_float128_Float16_type_fputil_sqrt_Float16_float128_float128.Invoke(x);
	}
}
