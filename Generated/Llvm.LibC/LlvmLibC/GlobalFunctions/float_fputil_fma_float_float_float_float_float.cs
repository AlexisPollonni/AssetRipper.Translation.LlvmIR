using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIffEET_T0_S3_S3_")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, float>(float, float, float)")]
internal static partial class float_fputil_fma_float_float_float_float_float
{
	public static float Invoke(float x, float y, float z)
	{
		return cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float_sizeof_float_sizeof_float_float_type_fputil_generic_fma_float_float_float_float_float.Invoke(x, y, z);
	}
}
