using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16mulf128
{
	[MangledName("f16mulf128")]
	[DemangledName("f16mulf128")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_mul_Float16_float128.Invoke(X, Y);
	}
}
