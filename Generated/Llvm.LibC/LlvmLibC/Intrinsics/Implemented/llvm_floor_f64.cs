using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.floor.f64")]
[DemangledName("llvm.floor.f64")]
internal static partial class llvm_floor_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0)
	{
		return NumericHelper.Floor(parameter_0);
	}
}
