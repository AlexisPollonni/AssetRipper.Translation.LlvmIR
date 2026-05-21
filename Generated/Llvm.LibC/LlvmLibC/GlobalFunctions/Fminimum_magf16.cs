using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_magf16
{
	[MangledName("fminimum_magf16")]
	[DemangledName("fminimum_magf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fminimum_mag_Float16_0.Invoke(X, Y);
	}
}
