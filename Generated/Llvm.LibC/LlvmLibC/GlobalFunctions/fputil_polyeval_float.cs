using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_polyeval_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalIfEENS_3cpp9enable_ifIXlestT_Lm8EES4_E4typeES4_S4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type __llvm_libc_20_1_2_::fputil::polyeval<float>(float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float) <= 8ul, float>::type")]
	public static float Invoke([NativeType("float")] float parameter_0, [NativeType("float")] float a0)
	{
		return a0;
	}
}
