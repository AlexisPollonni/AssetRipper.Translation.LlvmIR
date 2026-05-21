using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16sub
{
	[MangledName("f16sub")]
	[DemangledName("f16sub")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_sub_Float16_double.Invoke(X, Y);
	}
}
