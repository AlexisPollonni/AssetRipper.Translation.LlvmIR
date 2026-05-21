using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimumf16
{
	[MangledName("fminimumf16")]
	[DemangledName("fminimumf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fminimum_Float16_0.Invoke(X, Y);
	}
}
