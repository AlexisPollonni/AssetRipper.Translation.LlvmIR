using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strstr
{
	public unsafe static void* Invoke(void* haystack, void* needle)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		*unchecked((sbyte*)(&anon_izyfb8)) = -86;
		void* result = inline_strstr_strstr_impl_char_const_char_const_0.Invoke(haystack, needle, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		return result;
	}
}
