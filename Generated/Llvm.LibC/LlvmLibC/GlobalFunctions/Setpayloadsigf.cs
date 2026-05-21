using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadsigf
{
	[MangledName("setpayloadsigf")]
	[DemangledName("setpayloadsigf")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] float Pl)
	{
		return Fputil_setpayload_true_float.Invoke(Res, Pl) ? 1 : 0;
	}
}
