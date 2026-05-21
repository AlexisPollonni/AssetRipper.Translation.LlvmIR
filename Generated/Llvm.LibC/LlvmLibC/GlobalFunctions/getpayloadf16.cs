using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class getpayloadf16
{
	public unsafe static Half Invoke(void* x)
	{
		return fputil_getpayload_Float16.Invoke(*unchecked((Half*)x));
	}
}
