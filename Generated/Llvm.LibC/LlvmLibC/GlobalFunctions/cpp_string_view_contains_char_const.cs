using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp11string_view8containsEc")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::contains(char) const")]
internal static partial class cpp_string_view_contains_char_const
{
	public unsafe static bool Invoke(void* @this, sbyte c)
	{
		return cpp_string_view_find_first_of_char_unsigned_long_const.Invoke(@this, c, 0L) != -1L;
	}
}
