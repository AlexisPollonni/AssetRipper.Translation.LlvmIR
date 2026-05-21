using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_strstr_strcasestr_impl_char_const_char_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13inline_strstrIRZNS_19__strcasestr_impl__EPKcS2_E3$_0EEPcS2_S2_OT_")]
	[DemangledName("char* __llvm_libc_20_1_2_::inline_strstr<__llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0&>(char const*, char const*, __llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0&)")]
	[return: NativeType("char*")]
	public unsafe static void* Invoke([MangledName("haystack")][NativeType("char const*")] void* Haystack, [MangledName("needle")][NativeType("char const*")] void* Needle, [MangledName("comp")][NativeType("__llvm_libc_20_1_2_::__strcasestr_impl__(char const*, char const*)::$_0&")] void* Comp)
	{
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = Llvm_libc_20_1_2_inline_memmem_strcasestr_impl_char_const_char_const_0.Invoke(Haystack, Internal_string_length_char.Invoke(Haystack), Needle, Internal_string_length_char.Invoke(Needle), Comp);
		void* result = ptr;
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
