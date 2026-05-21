using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_fabs_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.fabs.f32")]
	[DemangledName("llvm.fabs.f32")]
	public static float Invoke(float parameter_0)
	{
		return NumericHelper.FAbs(parameter_0);
	}
}
