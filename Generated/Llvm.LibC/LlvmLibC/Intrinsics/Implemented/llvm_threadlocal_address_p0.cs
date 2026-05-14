using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.threadlocal.address.p0")]
[DemangledName("llvm.threadlocal.address.p0")]
internal static partial class llvm_threadlocal_address_p0
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(void* parameter_0)
	{
		return parameter_0;
	}
}
