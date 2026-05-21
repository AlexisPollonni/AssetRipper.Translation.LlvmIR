using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getpayloadf
{
	[MangledName("getpayloadf")]
	[DemangledName("getpayloadf")]
	public unsafe static float Invoke([MangledName("x")] void* X)
	{
		return Fputil_getpayload_float.Invoke(*unchecked((float*)X));
	}
}
