using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16mull
{
	[MangledName("f16mull")]
	[DemangledName("f16mull")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_mul_Float16_long_double.Invoke(X, Y);
	}
}
