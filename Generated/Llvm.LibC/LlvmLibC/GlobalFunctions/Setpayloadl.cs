using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadl
{
	[MangledName("setpayloadl")]
	[DemangledName("setpayloadl")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] double Pl)
	{
		return Fputil_setpayload_false_long_double.Invoke(Res, Pl) ? 1 : 0;
	}
}
