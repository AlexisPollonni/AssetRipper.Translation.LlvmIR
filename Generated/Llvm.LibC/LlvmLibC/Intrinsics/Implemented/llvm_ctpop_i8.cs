using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_ctpop_i8
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.ctpop.i8")]
	[DemangledName("llvm.ctpop.i8")]
	public static sbyte Invoke(sbyte parameter_0)
	{
		return NumericHelper.CtPop(parameter_0);
	}
}
