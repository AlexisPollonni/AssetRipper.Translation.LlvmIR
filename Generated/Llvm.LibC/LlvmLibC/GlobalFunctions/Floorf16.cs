using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Floorf16
{
	[MangledName("floorf16")]
	[DemangledName("floorf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_floor_Float16_0.Invoke(X);
	}
}
