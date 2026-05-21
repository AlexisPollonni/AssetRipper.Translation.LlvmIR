using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Issignalingf128
{
	[MangledName("issignalingf128")]
	[DemangledName("issignalingf128")]
	public unsafe static int Invoke([MangledName("x")] double X)
	{
		double num = X;
		return Fputil_issignaling_impl_float128_0.Invoke(&num);
	}
}
