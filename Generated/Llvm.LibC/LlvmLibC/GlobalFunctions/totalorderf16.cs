using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class totalorderf16
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(fputil_totalorder_Float16.Invoke(*(Half*)x, *(Half*)y)) ? 1 : 0;
	}
}
