using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminf16
{
	[MangledName("fminf16")]
	[DemangledName("fminf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fmin_Float16_0.Invoke(X, Y);
	}
}
