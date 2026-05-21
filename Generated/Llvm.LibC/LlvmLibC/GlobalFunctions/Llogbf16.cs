using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llogbf16
{
	[MangledName("llogbf16")]
	[DemangledName("llogbf16")]
	public static long Invoke([MangledName("x")] Half X)
	{
		return Fputil_intlogb_long_Float16.Invoke(X);
	}
}
