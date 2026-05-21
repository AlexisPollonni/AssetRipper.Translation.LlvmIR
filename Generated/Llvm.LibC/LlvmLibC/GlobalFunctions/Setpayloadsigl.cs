using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadsigl
{
	[MangledName("setpayloadsigl")]
	[DemangledName("setpayloadsigl")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] double Pl)
	{
		return Fputil_setpayload_true_long_double.Invoke(Res, Pl) ? 1 : 0;
	}
}
