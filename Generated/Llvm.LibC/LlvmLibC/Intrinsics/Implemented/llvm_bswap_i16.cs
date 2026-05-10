using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.bswap.i16")]
[DemangledName("llvm.bswap.i16")]
internal static partial class llvm_bswap_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short Invoke(short parameter_0)
	{
		return NumericHelper.BSwap(parameter_0);
	}
}
