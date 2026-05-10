using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_24inline_memmove_follow_upEPvPKvm")]
[DemangledName("__llvm_libc_20_1_2_::inline_memmove_follow_up(void*, void const*, unsigned long)")]
internal static partial class inline_memmove_follow_up_void_void_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		inline_memmove_follow_up_x86_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, count);
	}
}
