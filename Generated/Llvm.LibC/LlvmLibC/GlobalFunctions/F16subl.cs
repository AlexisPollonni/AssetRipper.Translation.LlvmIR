using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16subl
{
	[MangledName("f16subl")]
	[DemangledName("f16subl")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_sub_Float16_long_double.Invoke(X, Y);
	}
}
