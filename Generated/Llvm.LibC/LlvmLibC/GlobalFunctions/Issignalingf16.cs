using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Issignalingf16
{
	[MangledName("issignalingf16")]
	[DemangledName("issignalingf16")]
	public unsafe static int Invoke([MangledName("x")] Half X)
	{
		Half half = X;
		return Fputil_issignaling_impl_Float16_0.Invoke(&half);
	}
}
