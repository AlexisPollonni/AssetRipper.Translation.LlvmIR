using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.cttz.i16")]
[DemangledName("llvm.cttz.i16")]
internal static partial class llvm_cttz_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short Invoke(short parameter_0, bool parameter_1)
	{
		return NumericHelper.CtTz(parameter_0);
	}
}
