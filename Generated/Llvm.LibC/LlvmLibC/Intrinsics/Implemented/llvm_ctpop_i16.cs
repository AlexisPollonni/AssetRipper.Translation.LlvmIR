using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ctpop.i16")]
[DemangledName("llvm.ctpop.i16")]
internal static partial class llvm_ctpop_i16
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short Invoke(short parameter_0)
	{
		return NumericHelper.CtPop(parameter_0);
	}
}
