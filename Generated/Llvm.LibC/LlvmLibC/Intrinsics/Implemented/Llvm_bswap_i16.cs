using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_bswap_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.bswap.i16")]
	[DemangledName("llvm.bswap.i16")]
	public static short Invoke(short parameter_0)
	{
		return NumericHelper.BSwap(parameter_0);
	}
}
