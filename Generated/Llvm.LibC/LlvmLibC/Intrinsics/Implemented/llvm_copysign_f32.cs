using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_copysign_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.copysign.f32")]
	[DemangledName("llvm.copysign.f32")]
	public static float Invoke(float parameter_0, float parameter_1)
	{
		return NumericHelper.CopySign(parameter_0, parameter_1);
	}
}
