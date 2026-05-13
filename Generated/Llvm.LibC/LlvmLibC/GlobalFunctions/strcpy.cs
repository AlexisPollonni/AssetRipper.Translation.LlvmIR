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
		count = unchecked(unsigned_long_internal_string_length_char_char_const.Invoke(src) + 1L);
		inline_memcpy_void_void_const_unsigned_long.Invoke(dest, src, count);
		llvm_lifetime_end_p0.Invoke(8L, &count);
		return dest;
	}
}
