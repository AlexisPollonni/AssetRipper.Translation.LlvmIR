using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

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
