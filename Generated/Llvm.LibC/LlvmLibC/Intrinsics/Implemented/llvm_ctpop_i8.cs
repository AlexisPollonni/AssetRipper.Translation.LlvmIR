using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ctpop.i8")]
[DemangledName("llvm.ctpop.i8")]
internal static partial class llvm_ctpop_i8
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte Invoke(sbyte parameter_0)
	{
		return NumericHelper.CtPop(parameter_0);
	}
}
