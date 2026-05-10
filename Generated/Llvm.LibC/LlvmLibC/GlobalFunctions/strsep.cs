using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strsep
{
	public unsafe static void* Invoke(void* stringp, void* delim)
	{
		unchecked
		{
			if (*(IntPtr*)stringp == (IntPtr)(nint)0)
			{
				return null;
			}
			return char_internal_string_token_false_char_char_const_char.Invoke(*(void**)stringp, delim, stringp);
		}
	}
}
