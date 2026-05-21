using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nexttowardf16
{
	[MangledName("nexttowardf16")]
	[DemangledName("nexttowardf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] double Y)
	{
		return Fputil_nextafter_Float16_long_double_0.Invoke(X, Y);
	}
}
