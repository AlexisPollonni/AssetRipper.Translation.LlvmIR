using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_isgraph_pxk4zv
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isgraphEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isgraph(int)")]
	[CleanName("internal_isgraph")]
	public static bool Invoke([NativeType("int")] int ch)
	{
		return 32 < ch && ch < 127;
	}
}
