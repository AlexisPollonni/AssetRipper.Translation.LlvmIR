using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strcpy
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, void*>)(&Invoke));

	public unsafe static void* Invoke(void* dest, void* src)
	{
		long count = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &count);
		count = unchecked(internal_string_length_char.Invoke(src) + 1L);
		inline_memcpy.Invoke(dest, src, count);
		llvm_lifetime_end_p0.Invoke(8L, &count);
		return dest;
	}
}
