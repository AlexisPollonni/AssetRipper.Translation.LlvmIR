using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Issignalingl
{
	[MangledName("issignalingl")]
	[DemangledName("issignalingl")]
	public unsafe static int Invoke([MangledName("x")] double X)
	{
		double num = X;
		return Fputil_issignaling_impl_long_double_0.Invoke(&num);
	}
}
