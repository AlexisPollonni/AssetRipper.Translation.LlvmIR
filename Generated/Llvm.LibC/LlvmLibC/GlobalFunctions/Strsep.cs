using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strsep
{
	[MangledName("strsep")]
	[DemangledName("strsep")]
	public unsafe static void* Invoke([MangledName("stringp")] void* Stringp, [MangledName("delim")] void* Delim)
	{
		unchecked
		{
			if (*(IntPtr*)Stringp == (IntPtr)(nint)0)
			{
				return null;
			}
			return Internal_string_token_false.Invoke(*(void**)Stringp, Delim, Stringp);
		}
	}
}
