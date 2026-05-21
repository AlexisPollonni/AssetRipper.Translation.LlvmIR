using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Issignalingf
{
	[MangledName("issignalingf")]
	[DemangledName("issignalingf")]
	public unsafe static int Invoke([MangledName("x")] float X)
	{
		float num = X;
		return Fputil_issignaling_impl_float_0.Invoke(&num);
	}
}
