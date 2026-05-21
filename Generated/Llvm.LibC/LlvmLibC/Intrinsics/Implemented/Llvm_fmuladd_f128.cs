using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_fmuladd_f128
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.fmuladd.f128")]
	[DemangledName("llvm.fmuladd.f128")]
	public static double Invoke(double parameter_0, double parameter_1, double parameter_2)
	{
		return NumericHelper.FMulAdd(parameter_0, parameter_1, parameter_2);
	}
}
