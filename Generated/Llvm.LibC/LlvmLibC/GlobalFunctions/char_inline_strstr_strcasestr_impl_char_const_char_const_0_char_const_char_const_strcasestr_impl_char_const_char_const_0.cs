using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13inline_strstrIRZNS_19__strcasestr_impl__EPKcS2_E3$_0EEPcS2_S2_OT_")]
[DemangledName("char* __llvm_libc_20_1_2_::inline_strstr<__llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0&>(char const*, char const*, __llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0&)")]
internal static partial class char_inline_strstr_strcasestr_impl_char_const_char_const_0_char_const_char_const_strcasestr_impl_char_const_char_const_0
{
	public unsafe static void* Invoke(void* haystack, void* needle, void* comp)
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = void_inline_memmem_strcasestr_impl_char_const_char_const_0_void_const_unsigned_long_void_const_unsigned_long_strcasestr_impl_char_const_char_const_0.Invoke(haystack, unsigned_long_internal_string_length_char_char_const.Invoke(haystack), needle, unsigned_long_internal_string_length_char_char_const.Invoke(needle), comp);
		void* result = ptr;
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
