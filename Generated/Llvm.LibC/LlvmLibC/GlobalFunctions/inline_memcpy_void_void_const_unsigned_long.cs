using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13inline_memcpyEPvPKvm")]
[DemangledName("__llvm_libc_20_1_2_::inline_memcpy(void*, void const*, unsigned long)")]
internal static partial class inline_memcpy_void_void_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		inline_memcpy_x86_maybe_interpose_repmovsb_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, count);
	}
}
