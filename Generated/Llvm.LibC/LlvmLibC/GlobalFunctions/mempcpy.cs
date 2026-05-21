using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.GlobalFunctions;

internal static partial class mempcpy
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, long, void*>)(&Invoke));

	public unsafe static void* Invoke(void* dst, void* src, long count)
	{
		inline_memcpy.Invoke(dst, src, count);
		return unchecked((byte*)dst) + count;
	}
}
