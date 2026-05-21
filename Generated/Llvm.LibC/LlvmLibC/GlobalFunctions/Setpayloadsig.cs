using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadsig
{
	[MangledName("setpayloadsig")]
	[DemangledName("setpayloadsig")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] double Pl)
	{
		return Fputil_setpayload_true_double.Invoke(Res, Pl) ? 1 : 0;
	}
}
