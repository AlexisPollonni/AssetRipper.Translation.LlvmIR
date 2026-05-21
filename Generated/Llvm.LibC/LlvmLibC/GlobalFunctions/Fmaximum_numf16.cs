using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_numf16
{
	[MangledName("fmaximum_numf16")]
	[DemangledName("fmaximum_numf16")]
	public static Half Invoke([MangledName("x")] Half X, [MangledName("y")] Half Y)
	{
		return Fputil_fmaximum_num_Float16_0.Invoke(X, Y);
	}
}
