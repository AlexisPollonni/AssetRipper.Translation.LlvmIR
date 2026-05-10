using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ceil.f64")]
[DemangledName("llvm.ceil.f64")]
internal static partial class llvm_ceil_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0)
	{
		return NumericHelper.Ceil(parameter_0);
	}
}
