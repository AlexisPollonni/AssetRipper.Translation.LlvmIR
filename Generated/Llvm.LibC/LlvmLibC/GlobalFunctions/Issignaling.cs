using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Issignaling
{
	[MangledName("issignaling")]
	[DemangledName("issignaling")]
	public unsafe static int Invoke([MangledName("x")] double X)
	{
		double num = X;
		return Fputil_issignaling_impl_double_0.Invoke(&num);
	}
}
