using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strnlen
{
	public unsafe static long Invoke(void* src, long n)
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = internal_find_first_character.Invoke(src, 0, n);
		long result = ((ptr == null) ? n : unchecked((long)ptr - (long)src));
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
