using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.fmuladd.f80")]
[DemangledName("llvm.fmuladd.f80")]
internal static partial class llvm_fmuladd_f80
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0, double parameter_1, double parameter_2)
	{
		return NumericHelper.FMulAdd(parameter_0, parameter_1, parameter_2);
	}
}
