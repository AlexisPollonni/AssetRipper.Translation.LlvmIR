using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadsigf16
{
	[MangledName("setpayloadsigf16")]
	[DemangledName("setpayloadsigf16")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] Half Pl)
	{
		return Fputil_setpayload_true_Float16.Invoke(Res, Pl) ? 1 : 0;
	}
}
