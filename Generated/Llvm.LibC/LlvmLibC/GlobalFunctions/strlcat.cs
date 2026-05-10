using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strlcat
{
	public unsafe static long Invoke(void* dst, void* src, long size)
	{
		void* ptr = null;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = internal_find_first_character_unsigned_char_const_unsigned_char_unsigned_long.Invoke(dst, 0, size);
		unchecked
		{
			long result;
			if (ptr == null)
			{
				result = size + unsigned_long_internal_string_length_char_char_const.Invoke(src);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = (long)ptr - (long)dst;
				result = num + internal_strlcpy_char_char_const_unsigned_long.Invoke(ptr, src, size - num);
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
