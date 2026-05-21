using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getpayloadf128
{
	[MangledName("getpayloadf128")]
	[DemangledName("getpayloadf128")]
	public unsafe static double Invoke([MangledName("x")] void* X)
	{
		return Fputil_getpayload_float128.Invoke(*unchecked((double*)X));
	}
}
