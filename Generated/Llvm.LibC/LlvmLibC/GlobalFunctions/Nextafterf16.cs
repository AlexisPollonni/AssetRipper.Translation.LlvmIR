using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextafterf16
{
	[MangledName("nextafterf16")]
	[DemangledName("nextafterf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_nextafter_Float16_Float16_0.Invoke(X, Y);
	}
}
