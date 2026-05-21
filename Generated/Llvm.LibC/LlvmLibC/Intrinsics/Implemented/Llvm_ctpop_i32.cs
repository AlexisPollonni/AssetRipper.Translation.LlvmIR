using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_ctpop_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.ctpop.i32")]
	[DemangledName("llvm.ctpop.i32")]
	public static int Invoke(int parameter_0)
	{
		return NumericHelper.CtPop(parameter_0);
	}
}
