using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_magf16
{
	[MangledName("fmaximum_magf16")]
	[DemangledName("fmaximum_magf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fmaximum_mag_Float16_0.Invoke(X, Y);
	}
}
