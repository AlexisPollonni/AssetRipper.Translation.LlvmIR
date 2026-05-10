using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20find_first_characterEPKhhm")]
[DemangledName("__llvm_libc_20_1_2_::internal::find_first_character(unsigned char const*, unsigned char, unsigned long)")]
internal static partial class internal_find_first_character_unsigned_char_const_unsigned_char_unsigned_long
{
	public unsafe static void* Invoke(void* src, sbyte ch, long max_strlen)
	{
		return internal_find_first_character_byte_read_unsigned_char_const_unsigned_char_unsigned_long.Invoke(src, ch, max_strlen);
	}
}
