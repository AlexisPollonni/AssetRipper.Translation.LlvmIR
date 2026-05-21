using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadf
{
	[MangledName("setpayloadf")]
	[DemangledName("setpayloadf")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] float Pl)
	{
		return Fputil_setpayload_false_float.Invoke(Res, Pl) ? 1 : 0;
	}
}
