using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Logbf16
{
	[MangledName("logbf16")]
	[DemangledName("logbf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_logb_Float16_0.Invoke(X);
	}
}
