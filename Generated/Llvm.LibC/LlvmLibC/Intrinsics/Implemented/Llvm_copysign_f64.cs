using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_copysign_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.copysign.f64")]
	[DemangledName("llvm.copysign.f64")]
	public static double Invoke(double parameter_0, double parameter_1)
	{
		return NumericHelper.CopySign(parameter_0, parameter_1);
	}
}
