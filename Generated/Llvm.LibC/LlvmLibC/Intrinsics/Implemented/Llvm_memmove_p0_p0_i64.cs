using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_memmove_p0_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.memmove.p0.p0.i64")]
	[DemangledName("llvm.memmove.p0.p0.i64")]
	public unsafe static void Invoke(void* destination, void* source, long length, bool isVolatile)
	{
		IntrinsicFunctions.llvm_memmove_p0_p0_i64(destination, source, length, isVolatile);
	}
}
