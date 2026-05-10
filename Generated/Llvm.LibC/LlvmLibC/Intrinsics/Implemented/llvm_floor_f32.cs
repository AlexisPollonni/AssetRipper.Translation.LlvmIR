using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.floor.f32")]
[DemangledName("llvm.floor.f32")]
internal static partial class llvm_floor_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Invoke(float parameter_0)
	{
		return NumericHelper.Floor(parameter_0);
	}
}
