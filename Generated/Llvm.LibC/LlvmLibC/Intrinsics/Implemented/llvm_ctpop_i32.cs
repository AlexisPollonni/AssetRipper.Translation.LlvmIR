using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ctpop.i32")]
[DemangledName("llvm.ctpop.i32")]
internal static partial class llvm_ctpop_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke(int parameter_0)
	{
		return NumericHelper.CtPop(parameter_0);
	}
}
