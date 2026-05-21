using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_is_fpclass_f32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.is.fpclass.f32")]
	[DemangledName("llvm.is.fpclass.f32")]
	public static bool Invoke(float x, int mask)
	{
		return IntrinsicFunctions.llvm_is_fpclass_f32(x, mask);
	}
}
