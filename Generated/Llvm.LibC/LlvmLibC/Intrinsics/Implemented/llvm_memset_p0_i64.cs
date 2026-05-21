using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_memset_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.memset.p0.i64")]
	[DemangledName("llvm.memset.p0.i64")]
	public unsafe static void Invoke(void* destination, sbyte value, long length, bool isVolatile)
	{
		IntrinsicFunctions.llvm_memset_p0_i64(destination, value, length, isVolatile);
	}
}
