using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIfJffffEEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_DpT0_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type __llvm_libc_20_1_2_::fputil::polyeval<float, float, float, float, float>(float, float, float, float, float, float)")]
internal static partial class cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float_float_float_float_float_float_float
{
	public static float Invoke(float x, float a0, [MangledName("a")][CleanName("a")] float a_yc74sk, [MangledName("a1")][CleanName("a")] float a_ijazrn, [MangledName("a3")][CleanName("a")] float a_889uw5, [MangledName("a5")][CleanName("a")] float a_79nth8)
	{
		return cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(x, cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float_float_float_float_float.Invoke(x, a_yc74sk, a_ijazrn, a_889uw5, a_79nth8), a0);
	}
}
