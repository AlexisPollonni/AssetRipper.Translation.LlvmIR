using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadsigf128
{
	[MangledName("setpayloadsigf128")]
	[DemangledName("setpayloadsigf128")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] double Pl)
	{
		return Fputil_setpayload_true_float128.Invoke(Res, Pl) ? 1 : 0;
	}
}
