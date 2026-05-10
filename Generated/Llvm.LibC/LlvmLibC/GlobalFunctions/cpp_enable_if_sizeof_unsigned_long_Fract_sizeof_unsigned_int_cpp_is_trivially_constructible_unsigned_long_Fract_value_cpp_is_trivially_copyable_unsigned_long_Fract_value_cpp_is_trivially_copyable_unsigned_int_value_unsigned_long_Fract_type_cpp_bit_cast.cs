using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRmjEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned long _Fract) == sizeof (unsigned int) && cpp::is_trivially_constructible<unsigned long _Fract>::value && cpp::is_trivially_copyable<unsigned long _Fract>::value && cpp::is_trivially_copyable<unsigned int>::value, unsigned long _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned long _Fract, unsigned int>(unsigned int const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_long_Fract_sizeof_unsigned_int_cpp_is_trivially_constructible_unsigned_long_Fract_value_cpp_is_trivially_copyable_unsigned_long_Fract_value_cpp_is_trivially_copyable_unsigned_int_value_unsigned_long_Fract_type_cpp_bit_cast_unsigned_long_Fract_unsigned_int_unsigned_int_const
{
	public unsafe static int Invoke(void* from)
	{
		return *unchecked((int*)from);
	}
}
