using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ctlz.i64")]
[DemangledName("llvm.ctlz.i64")]
internal static partial class llvm_ctlz_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Invoke(long parameter_0, bool parameter_1)
	{
		return NumericHelper.CtLz(parameter_0);
	}
}
