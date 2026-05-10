using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.fabs.f32")]
[DemangledName("llvm.fabs.f32")]
internal static partial class llvm_fabs_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Invoke(float parameter_0)
	{
		return NumericHelper.FAbs(parameter_0);
	}
}
