using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16divf128
{
	[MangledName("f16divf128")]
	[DemangledName("f16divf128")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_div_Float16_float128.Invoke(X, Y);
	}
}
