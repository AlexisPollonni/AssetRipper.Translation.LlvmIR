using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.is.fpclass.f64")]
[DemangledName("llvm.is.fpclass.f64")]
internal static partial class llvm_is_fpclass_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Invoke(double x, int mask)
	{
		return IntrinsicFunctions.llvm_is_fpclass_f64(x, mask);
	}
}
