using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_ctpop_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.ctpop.i64")]
	[DemangledName("llvm.ctpop.i64")]
	public static long Invoke(long parameter_0)
	{
		return NumericHelper.CtPop(parameter_0);
	}
}
