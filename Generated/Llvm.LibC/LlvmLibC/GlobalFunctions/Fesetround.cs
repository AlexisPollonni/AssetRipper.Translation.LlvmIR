using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fesetround
{
	[MangledName("fesetround")]
	[DemangledName("fesetround")]
	public static int Invoke([MangledName("m")] int M)
	{
		return Fputil_set_round.Invoke(M);
	}
}
