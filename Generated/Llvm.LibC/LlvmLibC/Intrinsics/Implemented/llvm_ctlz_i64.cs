using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_ctlz_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.ctlz.i64")]
	[DemangledName("llvm.ctlz.i64")]
	public static long Invoke(long parameter_0, bool parameter_1)
	{
		return NumericHelper.CtLz(parameter_0);
	}
}
