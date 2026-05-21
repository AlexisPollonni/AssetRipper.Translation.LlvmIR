using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_numf
{
	[MangledName("fmaximum_numf")]
	[DemangledName("fmaximum_numf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fmaximum_num_float_0.Invoke(X, Y);
	}
}
