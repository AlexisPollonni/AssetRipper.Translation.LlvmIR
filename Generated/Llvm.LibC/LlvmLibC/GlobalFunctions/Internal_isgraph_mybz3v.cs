using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_isgraph_mybz3v
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isgraphEi.229")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isgraph(int) (.229)")]
	[CleanName("Internal_isgraph")]
	public static bool Invoke([MangledName("ch")][NativeType("int")] int Ch)
	{
		return 32 < Ch && Ch < 127;
	}
}
