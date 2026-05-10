using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.round.f32")]
[DemangledName("llvm.round.f32")]
internal static partial class llvm_round_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Invoke(float parameter_0)
	{
		return NumericHelper.Round(parameter_0);
	}
}
