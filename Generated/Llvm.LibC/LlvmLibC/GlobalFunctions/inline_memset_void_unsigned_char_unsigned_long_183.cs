using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memsetEPvhm.183")]
[DemangledName("__llvm_libc_20_1_2_::inline_memset(void*, unsigned char, unsigned long) (.183)")]
internal static partial class inline_memset_void_unsigned_char_unsigned_long_183
{
	public unsafe static void Invoke(void* dst, sbyte value, long count)
	{
		inline_memset_x86_cpp_byte_unsigned_char_unsigned_long_184.Invoke(dst, value, count);
	}
}
