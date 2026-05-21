using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadf128
{
	[MangledName("setpayloadf128")]
	[DemangledName("setpayloadf128")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] double Pl)
	{
		return Fputil_setpayload_false_float128.Invoke(Res, Pl) ? 1 : 0;
	}
}
