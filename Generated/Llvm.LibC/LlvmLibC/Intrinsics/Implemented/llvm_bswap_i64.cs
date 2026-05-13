using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.bswap.i64")]
[DemangledName("llvm.bswap.i64")]
internal static partial class llvm_bswap_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Invoke(long parameter_0)
	{
		return NumericHelper.BSwap(parameter_0);
	}
}
