using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class llvm_memcpy_inline_p0_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.memcpy.inline.p0.p0.i64")]
	[DemangledName("llvm.memcpy.inline.p0.p0.i64")]
	public unsafe static void Invoke(void* destination, void* source, long length, bool isVolatile)
	{
		IntrinsicFunctions.llvm_memcpy_p0_p0_i64(destination, source, length, isVolatile);
	}
}
