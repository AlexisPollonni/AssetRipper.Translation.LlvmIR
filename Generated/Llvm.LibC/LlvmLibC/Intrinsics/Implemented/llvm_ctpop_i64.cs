using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ctpop.i64")]
[DemangledName("llvm.ctpop.i64")]
internal static partial class llvm_ctpop_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Invoke(long parameter_0)
	{
		return NumericHelper.CtPop(parameter_0);
	}
}
