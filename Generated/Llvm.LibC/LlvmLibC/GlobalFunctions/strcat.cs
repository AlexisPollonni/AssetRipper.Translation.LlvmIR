using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strcat
{
	public unsafe static void* Invoke(void* dest, void* src)
	{
		long num = 0L;
		long num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_string_length_char.Invoke(dest);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = internal_string_length_char.Invoke(src);
		unchecked
		{
			((delegate*<sbyte*, void*, void*>)strcpy.__pointer)((sbyte*)dest + num, src);
			((sbyte*)dest)[num + num2] = 0;
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return dest;
		}
	}
}
