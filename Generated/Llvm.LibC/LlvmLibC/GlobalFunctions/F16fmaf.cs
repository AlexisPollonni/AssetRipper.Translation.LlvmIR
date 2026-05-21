using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class F16fmaf
{
	[MangledName("f16fmaf")]
	[DemangledName("f16fmaf")]
	public static Half Invoke([MangledName("x")] float X, [MangledName("y")] float Y, [MangledName("z")] float Z)
	{
		return Fputil_fma_Float16_float.Invoke(X, Y, Z);
	}
}
