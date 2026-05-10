using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

internal static partial class memset_explicit
{
	public unsafe static void* Invoke(void* dst, int value, long count)
	{
		inline_memset_void_unsigned_char_unsigned_long_204.Invoke(dst, unchecked((sbyte)value), count);
		AssemblyFunctions.M18(dst);
		return dst;
	}
}
