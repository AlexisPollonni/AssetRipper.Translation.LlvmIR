using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_polyeval_float_float_float_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIfJffffEEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_DpT0_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type __llvm_libc_20_1_2_::fputil::polyeval<float, float, float, float, float>(float, float, float, float, float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type")]
	public static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("a0")][NativeType("float")] float A0, [MangledName("a")][CleanName("A")][NativeType("float")] float A_yc74sk, [MangledName("a1")][CleanName("A")][NativeType("float")] float A_ijazrn, [MangledName("a3")][CleanName("A")][NativeType("float")] float A_889uw5, [MangledName("a5")][CleanName("A")][NativeType("float")] float A_79nth8)
	{
		return Fputil_multiply_add_float.Invoke(X, Fputil_polyeval_float_float_float_float.Invoke(X, A_yc74sk, A_ijazrn, A_889uw5, A_79nth8), A0);
	}
}
