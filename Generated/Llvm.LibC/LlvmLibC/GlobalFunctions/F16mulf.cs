using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16mulf
{
	[MangledName("f16mulf")]
	[DemangledName("f16mulf")]
	public static Half Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Generic_mul_Float16_float.Invoke(X, Y);
	}
}
