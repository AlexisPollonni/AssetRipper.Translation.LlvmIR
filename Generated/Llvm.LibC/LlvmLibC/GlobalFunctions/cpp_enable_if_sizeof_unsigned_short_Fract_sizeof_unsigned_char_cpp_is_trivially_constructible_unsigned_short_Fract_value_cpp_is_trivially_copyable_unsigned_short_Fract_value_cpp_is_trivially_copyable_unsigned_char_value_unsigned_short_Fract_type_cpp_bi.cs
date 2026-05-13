using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRthEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned short _Fract) == sizeof (unsigned char) && cpp::is_trivially_constructible<unsigned short _Fract>::value && cpp::is_trivially_copyable<unsigned short _Fract>::value && cpp::is_trivially_copyable<unsigned char>::value, unsigned short _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned short _Fract, unsigned char>(unsigned char const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_short_Fract_sizeof_unsigned_char_cpp_is_trivially_constructible_unsigned_short_Fract_value_cpp_is_trivially_copyable_unsigned_short_Fract_value_cpp_is_trivially_copyable_unsigned_char_value_unsigned_short_Fract_type_cpp_bit_cast_unsigned_short_Fract_unsigned_char_unsigned_char_const
{
	public unsafe static sbyte Invoke(void* from)
	{
		return *unchecked((sbyte*)from);
	}
}
