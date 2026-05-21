using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getpayloadl
{
	[MangledName("getpayloadl")]
	[DemangledName("getpayloadl")]
	public unsafe static double Invoke([MangledName("x")] void* X)
	{
		return Fputil_getpayload_long_double.Invoke(*unchecked((double*)X));
	}
}
