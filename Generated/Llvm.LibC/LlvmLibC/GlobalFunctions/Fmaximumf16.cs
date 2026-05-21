using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximumf16
{
	[MangledName("fmaximumf16")]
	[DemangledName("fmaximumf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fmaximum_Float16_0.Invoke(X, Y);
	}
}
