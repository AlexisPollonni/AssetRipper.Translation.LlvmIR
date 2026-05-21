using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16divf
{
	[MangledName("f16divf")]
	[DemangledName("f16divf")]
	public static Half Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Generic_div_Float16_float.Invoke(X, Y);
	}
}
