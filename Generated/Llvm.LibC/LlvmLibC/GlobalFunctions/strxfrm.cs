using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strxfrm
{
	public unsafe static long Invoke(void* dest, void* src, long n)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unsigned_long_internal_string_length_char_char_const.Invoke(src);
		unchecked
		{
			if ((ulong)n > (ulong)num)
			{
				inline_memcpy_void_void_const_unsigned_long.Invoke(dest, src, num + 1L);
			}
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
