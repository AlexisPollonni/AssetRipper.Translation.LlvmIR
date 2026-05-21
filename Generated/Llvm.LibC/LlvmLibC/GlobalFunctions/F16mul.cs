using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16mul
{
	[MangledName("f16mul")]
	[DemangledName("f16mul")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_mul_Float16_double.Invoke(X, Y);
	}
}
