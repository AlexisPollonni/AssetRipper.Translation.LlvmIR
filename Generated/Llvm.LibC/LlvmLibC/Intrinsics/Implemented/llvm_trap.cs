using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Intrinsics.Implemented;

[MangledName("llvm.trap")]
[DemangledName("llvm.trap")]
internal static partial class llvm_trap
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Invoke()
	{
		IntrinsicFunctions.Terminate();
	}
}
