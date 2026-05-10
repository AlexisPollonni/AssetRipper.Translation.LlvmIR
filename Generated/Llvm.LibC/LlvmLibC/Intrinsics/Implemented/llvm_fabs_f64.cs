using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.fabs.f64")]
[DemangledName("llvm.fabs.f64")]
internal static partial class llvm_fabs_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0)
	{
		return NumericHelper.FAbs(parameter_0);
	}
}
