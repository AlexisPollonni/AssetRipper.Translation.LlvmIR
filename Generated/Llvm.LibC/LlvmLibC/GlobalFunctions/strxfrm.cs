using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strxfrm
{
	public unsafe static long Invoke(void* dest, void* src, long n)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_string_length_char.Invoke(src);
		unchecked
		{
			if ((ulong)n > (ulong)num)
			{
				inline_memcpy.Invoke(dest, src, num + 1L);
			}
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
