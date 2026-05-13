using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

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
