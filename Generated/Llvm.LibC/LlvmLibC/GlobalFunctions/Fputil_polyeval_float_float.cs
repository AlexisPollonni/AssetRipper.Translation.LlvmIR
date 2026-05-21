using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_polyeval_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIfJfEEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_DpT0_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type __llvm_libc_20_1_2_::fputil::polyeval<float, float>(float, float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type")]
	public static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("a0")][NativeType("float")] float A0, [MangledName("a")][NativeType("float")] float A)
	{
		return Fputil_multiply_add_float.Invoke(X, Fputil_polyeval_float.Invoke(X, A), A0);
	}
}
