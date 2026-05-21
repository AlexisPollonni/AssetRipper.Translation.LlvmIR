using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset_explicit
{
	[MangledName("memset_explicit")]
	[DemangledName("memset_explicit")]
	public unsafe static void* Invoke([MangledName("dst")] void* Dst, [MangledName("value")] int Value, [MangledName("count")] long Count)
	{
		Llvm_libc_20_1_2_inline_memset_rivytf.Invoke(Dst, unchecked((sbyte)Value), Count);
		IntrinsicFunctions.AsmMemoryBarrierPtr(Dst);
		return Dst;
	}
}
