using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strcasestr
{
	public unsafe static void* Invoke(void* haystack, void* needle)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		*unchecked((sbyte*)(&anon_izyfb8)) = -86;
		void* result = char_inline_strstr_strcasestr_impl_char_const_char_const_0_char_const_char_const_strcasestr_impl_char_const_char_const_0.Invoke(haystack, needle, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		return result;
	}
}
