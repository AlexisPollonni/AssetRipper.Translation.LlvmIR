using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.cttz.i64")]
[DemangledName("llvm.cttz.i64")]
internal static partial class llvm_cttz_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Invoke(long parameter_0, bool parameter_1)
	{
		return NumericHelper.CtTz(parameter_0);
	}
}
