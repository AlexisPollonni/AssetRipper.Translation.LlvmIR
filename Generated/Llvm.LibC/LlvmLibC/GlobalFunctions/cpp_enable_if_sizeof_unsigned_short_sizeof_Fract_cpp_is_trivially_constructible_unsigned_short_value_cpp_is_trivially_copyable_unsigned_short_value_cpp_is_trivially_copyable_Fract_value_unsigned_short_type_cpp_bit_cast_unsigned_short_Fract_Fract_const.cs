using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castItDRiEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned short) == sizeof (_Fract) && cpp::is_trivially_constructible<unsigned short>::value && cpp::is_trivially_copyable<unsigned short>::value && cpp::is_trivially_copyable<_Fract>::value, unsigned short>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned short, _Fract>(_Fract const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_short_sizeof_Fract_cpp_is_trivially_constructible_unsigned_short_value_cpp_is_trivially_copyable_unsigned_short_value_cpp_is_trivially_copyable_Fract_value_unsigned_short_type_cpp_bit_cast_unsigned_short_Fract_Fract_const
{
	public unsafe static short Invoke(void* from)
	{
		return *unchecked((short*)from);
	}
}
