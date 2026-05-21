using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_isgraph_mybz3v
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isgraphEi.229")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isgraph(int) (.229)")]
	[CleanName("internal_isgraph")]
	public static bool Invoke([NativeType("int")] int ch)
	{
		return 32 < ch && ch < 127;
	}
}
