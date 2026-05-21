using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bzero
{
	[MangledName("bzero")]
	[DemangledName("bzero")]
	public unsafe static void Invoke([MangledName("ptr")] void* Ptr, [MangledName("count")] long Count)
	{
		Llvm_libc_20_1_2_inline_bzero_vdhkgh.Invoke(Ptr, Count);
	}
}
