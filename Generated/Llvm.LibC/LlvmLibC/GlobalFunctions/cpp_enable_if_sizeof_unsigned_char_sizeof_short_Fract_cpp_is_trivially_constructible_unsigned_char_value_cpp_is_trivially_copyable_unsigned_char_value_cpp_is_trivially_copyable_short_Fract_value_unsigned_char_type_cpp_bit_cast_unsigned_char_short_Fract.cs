using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIhDRsEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned char) == sizeof (short _Fract) && cpp::is_trivially_constructible<unsigned char>::value && cpp::is_trivially_copyable<unsigned char>::value && cpp::is_trivially_copyable<short _Fract>::value, unsigned char>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned char, short _Fract>(short _Fract const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_char_sizeof_short_Fract_cpp_is_trivially_constructible_unsigned_char_value_cpp_is_trivially_copyable_unsigned_char_value_cpp_is_trivially_copyable_short_Fract_value_unsigned_char_type_cpp_bit_cast_unsigned_char_short_Fract_short_Fract_const
{
	public unsafe static sbyte Invoke(void* from)
	{
		return *unchecked((sbyte*)from);
	}
}
