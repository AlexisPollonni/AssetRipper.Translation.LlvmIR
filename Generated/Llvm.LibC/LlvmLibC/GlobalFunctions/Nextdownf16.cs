using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextdownf16
{
	[MangledName("nextdownf16")]
	[DemangledName("nextdownf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_nextupdown_true_Float16_0.Invoke(X);
	}
}
