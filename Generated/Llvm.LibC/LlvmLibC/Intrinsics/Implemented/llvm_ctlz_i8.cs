using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.ctlz.i8")]
[DemangledName("llvm.ctlz.i8")]
internal static partial class llvm_ctlz_i8
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte Invoke(sbyte parameter_0, bool parameter_1)
	{
		return NumericHelper.CtLz(parameter_0);
	}
}
