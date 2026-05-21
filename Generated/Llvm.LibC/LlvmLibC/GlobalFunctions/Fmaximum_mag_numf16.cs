using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_mag_numf16
{
	[MangledName("fmaximum_mag_numf16")]
	[DemangledName("fmaximum_mag_numf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fmaximum_mag_num_Float16_0.Invoke(X, Y);
	}
}
