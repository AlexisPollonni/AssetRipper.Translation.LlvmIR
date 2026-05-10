using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIPcS2_EENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS4_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valuesr3cpp21is_trivially_copyableIS5_EE5valueES4_E4typeERKS5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (char*) == sizeof (char*) && cpp::is_trivially_constructible<char*>::value && cpp::is_trivially_copyable<char*>::value && cpp::is_trivially_copyable<char*>::value, char*>::type __llvm_libc_20_1_2_::cpp::bit_cast<char*, char*>(char* const&)")]
internal static partial class cpp_enable_if_sizeof_char_sizeof_char_cpp_is_trivially_constructible_char_value_cpp_is_trivially_copyable_char_value_cpp_is_trivially_copyable_char_value_char_type_cpp_bit_cast_char_char_char_const
{
	public unsafe static void* Invoke(void* from)
	{
		return *unchecked((void**)from);
	}
}
