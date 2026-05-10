using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_20__strncasecmp_impl__EPKcS1_mENK3$_0clEcc")]
[DemangledName("__llvm_libc_20_1_2_::__strncasecmp_impl__(char const*, char const*, unsigned long)::$_0::operator()(char, char) const")]
internal static partial class strncasecmp_impl_char_const_char_const_unsigned_long_0_operator_char_char_const
{
	public unsafe static int Invoke(void* @this, sbyte a, sbyte b)
	{
		return internal_tolower_int_181.Invoke(a) - internal_tolower_int_181.Invoke(b);
	}
}
