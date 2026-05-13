using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRljEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long _Fract) == sizeof (unsigned int) && cpp::is_trivially_constructible<long _Fract>::value && cpp::is_trivially_copyable<long _Fract>::value && cpp::is_trivially_copyable<unsigned int>::value, long _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<long _Fract, unsigned int>(unsigned int const&)")]
internal static partial class cpp_enable_if_sizeof_long_Fract_sizeof_unsigned_int_cpp_is_trivially_constructible_long_Fract_value_cpp_is_trivially_copyable_long_Fract_value_cpp_is_trivially_copyable_unsigned_int_value_long_Fract_type_cpp_bit_cast_long_Fract_unsigned_int_unsigned_int_const
{
	public unsafe static int Invoke(void* from)
	{
		return *unchecked((int*)from);
	}
}
