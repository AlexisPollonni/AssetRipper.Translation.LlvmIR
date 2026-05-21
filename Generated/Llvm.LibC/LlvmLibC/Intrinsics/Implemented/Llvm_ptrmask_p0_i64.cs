using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_ptrmask_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.ptrmask.p0.i64")]
	[DemangledName("llvm.ptrmask.p0.i64")]
	public unsafe static void* Invoke(void* ptr, long mask)
	{
		return IntrinsicFunctions.llvm_ptrmask_p0_i64(ptr, mask);
	}
}
