using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_expect_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.expect.i64")]
	[DemangledName("llvm.expect.i64")]
	public static long Invoke(long parameter_0, long parameter_1)
	{
		return parameter_0;
	}
}
