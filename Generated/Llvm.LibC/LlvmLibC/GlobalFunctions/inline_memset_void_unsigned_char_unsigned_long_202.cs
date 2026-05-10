using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memsetEPvhm.202")]
[DemangledName("__llvm_libc_20_1_2_::inline_memset(void*, unsigned char, unsigned long) (.202)")]
internal static partial class inline_memset_void_unsigned_char_unsigned_long_202
{
	public unsafe static void Invoke(void* dst, sbyte value, long count)
	{
		inline_memset_x86_cpp_byte_unsigned_char_unsigned_long_203.Invoke(dst, value, count);
	}
}
