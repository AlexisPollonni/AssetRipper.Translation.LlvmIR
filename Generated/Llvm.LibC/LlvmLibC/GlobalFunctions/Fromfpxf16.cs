using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpxf16
{
	[MangledName("fromfpxf16")]
	[DemangledName("fromfpxf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_true_Float16.Invoke(X, Rnd, Width);
	}
}
