using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_memcpy
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13inline_memcpyEPvPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memcpy(void*, void const*, unsigned long)")]
	public unsafe static void Invoke([NativeType("void*")] void* dst, [NativeType("void const*")] void* src, [NativeType("unsigned long")] long count)
	{
		inline_memcpy_x86_maybe_interpose_repmovsb.Invoke(dst, src, count);
	}
}
