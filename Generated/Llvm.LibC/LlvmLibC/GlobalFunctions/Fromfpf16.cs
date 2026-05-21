using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fromfpf16
{
	[MangledName("fromfpf16")]
	[DemangledName("fromfpf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfp_true_Float16.Invoke(X, Rnd, Width);
	}
}
