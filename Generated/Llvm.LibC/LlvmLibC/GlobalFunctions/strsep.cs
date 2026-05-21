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
			return internal_string_token_false.Invoke(*(void**)stringp, delim, stringp);
		}
	}
}
