using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16addl
{
	[MangledName("f16addl")]
	[DemangledName("f16addl")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_add_Float16_long_double.Invoke(X, Y);
	}
}
