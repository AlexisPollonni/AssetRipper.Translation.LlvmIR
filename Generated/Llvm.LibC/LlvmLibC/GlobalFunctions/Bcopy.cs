using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bcopy
{
	[MangledName("bcopy")]
	[DemangledName("bcopy")]
	public unsafe static void Invoke([MangledName("src")] void* Src, [MangledName("dst")] void* Dst, [MangledName("count")] long Count)
	{
		Llvm_libc_20_1_2_inline_memmove.Invoke(Dst, Src, Count);
	}
}
