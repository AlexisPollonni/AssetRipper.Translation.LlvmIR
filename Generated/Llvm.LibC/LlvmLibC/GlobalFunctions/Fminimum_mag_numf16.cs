using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_mag_numf16
{
	[MangledName("fminimum_mag_numf16")]
	[DemangledName("fminimum_mag_numf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fminimum_mag_num_Float16_0.Invoke(X, Y);
	}
}
