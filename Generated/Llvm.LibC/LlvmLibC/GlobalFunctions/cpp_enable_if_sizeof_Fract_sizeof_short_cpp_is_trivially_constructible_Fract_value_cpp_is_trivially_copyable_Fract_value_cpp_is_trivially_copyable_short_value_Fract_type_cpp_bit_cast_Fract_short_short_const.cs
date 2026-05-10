using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRisEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Fract) == sizeof (short) && cpp::is_trivially_constructible<_Fract>::value && cpp::is_trivially_copyable<_Fract>::value && cpp::is_trivially_copyable<short>::value, _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<_Fract, short>(short const&)")]
internal static partial class cpp_enable_if_sizeof_Fract_sizeof_short_cpp_is_trivially_constructible_Fract_value_cpp_is_trivially_copyable_Fract_value_cpp_is_trivially_copyable_short_value_Fract_type_cpp_bit_cast_Fract_short_short_const
{
	public unsafe static short Invoke(void* from)
	{
		return *unchecked((short*)from);
	}
}
