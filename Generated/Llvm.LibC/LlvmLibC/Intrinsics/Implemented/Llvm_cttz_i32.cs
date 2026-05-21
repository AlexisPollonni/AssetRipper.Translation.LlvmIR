using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_cttz_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.cttz.i32")]
	[DemangledName("llvm.cttz.i32")]
	public static int Invoke(int parameter_0, bool parameter_1)
	{
		return NumericHelper.CtTz(parameter_0);
	}
}
