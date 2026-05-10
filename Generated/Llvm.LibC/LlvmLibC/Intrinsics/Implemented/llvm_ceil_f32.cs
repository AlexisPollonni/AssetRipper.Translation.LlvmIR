using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ceil.f32")]
[DemangledName("llvm.ceil.f32")]
internal static partial class llvm_ceil_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Invoke(float parameter_0)
	{
		return NumericHelper.Ceil(parameter_0);
	}
}
