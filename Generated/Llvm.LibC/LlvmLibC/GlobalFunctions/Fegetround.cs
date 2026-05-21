using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fegetround
{
	[MangledName("fegetround")]
	[DemangledName("fegetround")]
	public static int Invoke()
	{
		return Fputil_get_round.Invoke();
	}
}
