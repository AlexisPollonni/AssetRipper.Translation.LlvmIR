using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_fabs_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.fabs.f64")]
	[DemangledName("llvm.fabs.f64")]
	public static double Invoke(double parameter_0)
	{
		return NumericHelper.FAbs(parameter_0);
	}
}
