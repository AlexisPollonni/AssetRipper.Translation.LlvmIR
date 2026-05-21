using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ufromfpf16
{
	[MangledName("ufromfpf16")]
	[DemangledName("ufromfpf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("rnd")] int Rnd, [MangledName("width")] int Width)
	{
		return Fputil_fromfp_false_Float16.Invoke(X, Rnd, Width);
	}
}
