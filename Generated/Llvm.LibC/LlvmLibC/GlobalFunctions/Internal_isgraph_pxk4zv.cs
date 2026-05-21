using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_isgraph_pxk4zv
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7isgraphEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::isgraph(int)")]
	[CleanName("Internal_isgraph")]
	public static bool Invoke([MangledName("ch")][NativeType("int")] int Ch)
	{
		return 32 < Ch && Ch < 127;
	}
}
