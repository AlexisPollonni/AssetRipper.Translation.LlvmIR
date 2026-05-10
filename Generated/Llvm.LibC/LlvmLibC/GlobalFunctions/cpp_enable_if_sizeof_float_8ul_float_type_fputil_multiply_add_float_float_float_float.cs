using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIfEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type __llvm_libc_20_1_2_::fputil::multiply_add<float>(float, float, float)")]
internal static partial class cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float
{
	public static float Invoke(float x, float y, float z)
	{
		return llvm_fmuladd_f32.Invoke(x, y, z);
	}
}
