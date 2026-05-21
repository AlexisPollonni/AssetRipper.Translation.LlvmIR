using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_bswap_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.bswap.i32")]
	[DemangledName("llvm.bswap.i32")]
	public static int Invoke(int parameter_0)
	{
		return NumericHelper.BSwap(parameter_0);
	}
}
