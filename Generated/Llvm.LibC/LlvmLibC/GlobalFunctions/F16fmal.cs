using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16fmal
{
	[MangledName("f16fmal")]
	[DemangledName("f16fmal")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("z")] double Z)
	{
		return Fputil_fma_Float16_long_double.Invoke(X, Y, Z);
	}
}
