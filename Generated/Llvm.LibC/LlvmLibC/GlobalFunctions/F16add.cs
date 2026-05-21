using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16add
{
	[MangledName("f16add")]
	[DemangledName("f16add")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_add_Float16_double.Invoke(X, Y);
	}
}
