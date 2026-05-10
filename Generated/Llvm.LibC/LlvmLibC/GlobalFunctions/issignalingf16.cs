using System;

namespace LlvmLibC.GlobalFunctions;

internal static partial class issignalingf16
{
	public unsafe static int Invoke(Half x)
	{
		Half half = x;
		return int_fputil_issignaling_impl_Float16_0_Float16_const.Invoke(&half);
	}
}
