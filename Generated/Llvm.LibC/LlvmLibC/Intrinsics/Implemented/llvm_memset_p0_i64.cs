using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.memset.p0.i64")]
[DemangledName("llvm.memset.p0.i64")]
internal static partial class llvm_memset_p0_i64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* destination, sbyte value, long length, bool isVolatile)
	{
		IntrinsicFunctions.llvm_memset_p0_i64(destination, value, length, isVolatile);
	}
}
