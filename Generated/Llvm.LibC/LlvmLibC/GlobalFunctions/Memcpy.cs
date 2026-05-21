using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy
{
	[MangledName("memcpy")]
	[DemangledName("memcpy")]
	public unsafe static void* Invoke([MangledName("dst")] void* Dst, [MangledName("src")] void* Src, [MangledName("size")] long Size)
	{
		Llvm_libc_20_1_2_inline_memcpy.Invoke(Dst, Src, Size);
		return Dst;
	}
}
