using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getpayloadf16
{
	[MangledName("getpayloadf16")]
	[DemangledName("getpayloadf16")]
	public unsafe static Half Invoke([MangledName("x")] void* X)
	{
		return Fputil_getpayload_Float16.Invoke(*unchecked((Half*)X));
	}
}
