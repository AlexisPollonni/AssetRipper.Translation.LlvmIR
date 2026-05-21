using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_ctlz_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.ctlz.i16")]
	[DemangledName("llvm.ctlz.i16")]
	public static short Invoke(short parameter_0, bool parameter_1)
	{
		return NumericHelper.CtLz(parameter_0);
	}
}
