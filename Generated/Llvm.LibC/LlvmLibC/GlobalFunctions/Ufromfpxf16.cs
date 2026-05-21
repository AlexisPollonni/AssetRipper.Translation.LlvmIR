using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ufromfpxf16
{
	[MangledName("ufromfpxf16")]
	[DemangledName("ufromfpxf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfpx_false_Float16.Invoke(X, Rnd, Width);
	}
}
