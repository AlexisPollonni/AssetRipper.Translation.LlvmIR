using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ctlz.i32")]
[DemangledName("llvm.ctlz.i32")]
internal static partial class llvm_ctlz_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke(int parameter_0, bool parameter_1)
	{
		return NumericHelper.CtLz(parameter_0);
	}
}
