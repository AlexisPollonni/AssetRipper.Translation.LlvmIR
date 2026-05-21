using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strlcat
{
	public unsafe static long Invoke(void* dst, void* src, long size)
	{
		void* ptr = null;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = internal_find_first_character.Invoke(dst, 0, size);
		unchecked
		{
			long result;
			if (ptr == null)
			{
				result = size + internal_string_length_char.Invoke(src);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = (long)ptr - (long)dst;
				result = num + internal_strlcpy.Invoke(ptr, src, size - num);
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
