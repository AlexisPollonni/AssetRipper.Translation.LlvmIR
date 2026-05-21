using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_polyeval_float_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIfJffEEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_DpT0_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type __llvm_libc_20_1_2_::fputil::polyeval<float, float, float>(float, float, float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type")]
	public static float Invoke([NativeType("float")] float x, [NativeType("float")] float a0, [MangledName("a")][CleanName("a")][NativeType("float")] float a_yc74sk, [MangledName("a1")][CleanName("a")][NativeType("float")] float a_ijazrn)
	{
		return fputil_multiply_add_float.Invoke(x, fputil_polyeval_float_float.Invoke(x, a_yc74sk, a_ijazrn), a0);
	}
}
