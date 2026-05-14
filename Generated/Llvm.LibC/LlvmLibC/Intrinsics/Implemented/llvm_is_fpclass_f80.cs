using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.is.fpclass.f80")]
[DemangledName("llvm.is.fpclass.f80")]
internal static partial class llvm_is_fpclass_f80
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Invoke(double x, int mask)
	{
		return IntrinsicFunctions.llvm_is_fpclass_f80(x, mask);
	}
}
