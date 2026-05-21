using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class setpayloadsigf16
{
	public unsafe static int Invoke(void* res, Half pl)
	{
		return fputil_setpayload_true_Float16.Invoke(res, pl) ? 1 : 0;
	}
}
