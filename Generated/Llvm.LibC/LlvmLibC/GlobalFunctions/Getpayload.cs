using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getpayload
{
	[MangledName("getpayload")]
	[DemangledName("getpayload")]
	public unsafe static double Invoke([MangledName("x")] void* X)
	{
		return Fputil_getpayload_double.Invoke(*unchecked((double*)X));
	}
}
