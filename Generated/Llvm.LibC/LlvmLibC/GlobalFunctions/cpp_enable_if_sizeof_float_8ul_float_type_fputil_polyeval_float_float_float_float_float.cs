using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIfJfEEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_DpT0_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type __llvm_libc_20_1_2_::fputil::polyeval<float, float>(float, float, float)")]
internal static partial class cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float
{
	public static float Invoke(float x, float a0, float a)
	{
		return fputil_multiply_add_float_float_float.Invoke(x, cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float.Invoke(x, a), a0);
	}
}
