using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRsaEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (short _Fract) == sizeof (signed char) && cpp::is_trivially_constructible<short _Fract>::value && cpp::is_trivially_copyable<short _Fract>::value && cpp::is_trivially_copyable<signed char>::value, short _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<short _Fract, signed char>(signed char const&)")]
internal static partial class cpp_enable_if_sizeof_short_Fract_sizeof_signed_char_cpp_is_trivially_constructible_short_Fract_value_cpp_is_trivially_copyable_short_Fract_value_cpp_is_trivially_copyable_signed_char_value_short_Fract_type_cpp_bit_cast_short_Fract_signed_char_signed_char_const
{
	public unsafe static sbyte Invoke(void* from)
	{
		return *unchecked((sbyte*)from);
	}
}
