using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_cttz_i8
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.cttz.i8")]
	[DemangledName("llvm.cttz.i8")]
	public static sbyte Invoke(sbyte parameter_0, bool parameter_1)
	{
		return NumericHelper.CtTz(parameter_0);
	}
}
