using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextupf16
{
	[MangledName("nextupf16")]
	[DemangledName("nextupf16")]
	public static Half Invoke([MangledName("x")] Half X)
	{
		return Fputil_nextupdown_false_Float16_0.Invoke(X);
	}
}
