using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Copysignf
{
	[MangledName("copysignf")]
	[DemangledName("copysignf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Llvm_copysign_f32.Invoke(X, Y);
	}
}
