using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Setpayloadf16
{
	[MangledName("setpayloadf16")]
	[DemangledName("setpayloadf16")]
	public unsafe static int Invoke([MangledName("res")] void* Res, [MangledName("pl")] Half Pl)
	{
		return Fputil_setpayload_false_Float16.Invoke(Res, Pl) ? 1 : 0;
	}
}
