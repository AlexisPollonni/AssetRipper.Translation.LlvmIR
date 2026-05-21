using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16fma
{
	[MangledName("f16fma")]
	[DemangledName("f16fma")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("z")] double Z)
	{
		return Fputil_fma_Float16_double.Invoke(X, Y, Z);
	}
}
