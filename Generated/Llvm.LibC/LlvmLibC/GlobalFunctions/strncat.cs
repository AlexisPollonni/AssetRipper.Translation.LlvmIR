using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strncat
{
	public unsafe static void* Invoke(void* dest, void* src, long count)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_string_length_char.Invoke(src);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = (((ulong)num <= (ulong)count) ? num : count);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = internal_string_length_char.Invoke(dest);
			((delegate*<sbyte*, void*, long, void*>)strncpy.__pointer)((sbyte*)dest + num3, src, num2);
			((sbyte*)dest)[num3 + num2] = 0;
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return dest;
		}
	}
}
