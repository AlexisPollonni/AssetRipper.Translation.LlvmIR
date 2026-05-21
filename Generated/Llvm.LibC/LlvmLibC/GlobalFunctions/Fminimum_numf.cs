using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_numf
{
	[MangledName("fminimum_numf")]
	[DemangledName("fminimum_numf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fminimum_num_float_0.Invoke(X, Y);
	}
}
