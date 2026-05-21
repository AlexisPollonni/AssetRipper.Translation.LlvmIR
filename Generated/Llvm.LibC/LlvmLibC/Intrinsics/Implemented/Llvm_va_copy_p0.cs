using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Intrinsics.Implemented;

internal static partial class Llvm_va_copy_p0
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MangledName("llvm.va_copy.p0")]
	[DemangledName("llvm.va_copy.p0")]
	public unsafe static void Invoke(void* destination, void* source)
	{
		unchecked
		{
			IntrinsicFunctions.llvm_va_copy((void**)destination, (void**)source);
		}
	}
}
