using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ctlz.i16")]
[DemangledName("llvm.ctlz.i16")]
internal static partial class llvm_ctlz_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short Invoke(short parameter_0, bool parameter_1)
	{
		return NumericHelper.CtLz(parameter_0);
	}
}
