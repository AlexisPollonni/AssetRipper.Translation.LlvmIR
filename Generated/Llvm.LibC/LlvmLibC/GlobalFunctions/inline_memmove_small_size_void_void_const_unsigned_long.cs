using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_25inline_memmove_small_sizeEPvPKvm")]
[DemangledName("__llvm_libc_20_1_2_::inline_memmove_small_size(void*, void const*, unsigned long)")]
internal static partial class inline_memmove_small_size_void_void_const_unsigned_long
{
	public unsafe static bool Invoke(void* dst, void* src, long count)
	{
		return inline_memmove_small_size_x86_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, count);
	}
}
