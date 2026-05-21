using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strcpy
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, void*>)(&Invoke));

	[MangledName("strcpy")]
	[DemangledName("strcpy")]
	public unsafe static void* Invoke([MangledName("dest")] void* Dest, [MangledName("src")] void* Src)
	{
		long count = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &count);
		count = unchecked(Internal_string_length_char.Invoke(Src) + 1L);
		Llvm_libc_20_1_2_inline_memcpy.Invoke(Dest, Src, count);
		Llvm_lifetime_end_p0.Invoke(8L, &count);
		return Dest;
	}
}
