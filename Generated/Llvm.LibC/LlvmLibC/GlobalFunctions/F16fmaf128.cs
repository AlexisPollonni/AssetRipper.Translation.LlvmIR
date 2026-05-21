using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16fmaf128
{
	[MangledName("f16fmaf128")]
	[DemangledName("f16fmaf128")]
	public static Half Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("z")] double Z)
	{
		return Fputil_fma_Float16_float128.Invoke(X, Y, Z);
	}
}
