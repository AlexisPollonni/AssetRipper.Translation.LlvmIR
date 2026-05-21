using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Isnan
{
	[MangledName("isnan")]
	[DemangledName("isnan")]
	public static int Invoke([MangledName("x")] double X)
	{
		return Llvm_is_fpclass_f64.Invoke(X, 3) ? 1 : 0;
	}
}
