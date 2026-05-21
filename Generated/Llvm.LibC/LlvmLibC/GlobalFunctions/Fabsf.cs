using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fabsf
{
	[MangledName("fabsf")]
	[DemangledName("fabsf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Llvm_fabs_f32.Invoke(X);
	}
}
