using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_threadlocal_address_p0
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.threadlocal.address.p0")]
	[DemangledName("llvm.threadlocal.address.p0")]
	public unsafe static void* Invoke(void* parameter_0)
	{
		return parameter_0;
	}
}
