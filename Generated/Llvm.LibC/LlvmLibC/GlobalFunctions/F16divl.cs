using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16divl
{
	[MangledName("f16divl")]
	[DemangledName("f16divl")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_div_Float16_long_double.Invoke(X, Y);
	}
}
