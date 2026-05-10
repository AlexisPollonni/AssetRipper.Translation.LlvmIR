using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.cttz.i32")]
[DemangledName("llvm.cttz.i32")]
internal static partial class llvm_cttz_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke(int parameter_0, bool parameter_1)
	{
		return NumericHelper.CtTz(parameter_0);
	}
}
