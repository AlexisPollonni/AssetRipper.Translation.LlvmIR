using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Copysign
{
	[MangledName("copysign")]
	[DemangledName("copysign")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Llvm_copysign_f64.Invoke(X, Y);
	}
}
