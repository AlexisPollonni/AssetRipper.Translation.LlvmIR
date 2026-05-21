using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fabs
{
	[MangledName("fabs")]
	[DemangledName("fabs")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Llvm_fabs_f64.Invoke(X);
	}
}
