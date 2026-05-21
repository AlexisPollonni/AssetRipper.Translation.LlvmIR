using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16div
{
	[MangledName("f16div")]
	[DemangledName("f16div")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_div_Float16_double.Invoke(X, Y);
	}
}
