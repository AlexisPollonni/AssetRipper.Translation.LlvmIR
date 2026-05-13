using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDAtDRjEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned short _Accum) == sizeof (unsigned _Fract) && cpp::is_trivially_constructible<unsigned short _Accum>::value && cpp::is_trivially_copyable<unsigned short _Accum>::value && cpp::is_trivially_copyable<unsigned _Fract>::value, unsigned short _Accum>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned short _Accum, unsigned _Fract>(unsigned _Fract const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_short_Accum_sizeof_unsigned_Fract_cpp_is_trivially_constructible_unsigned_short_Accum_value_cpp_is_trivially_copyable_unsigned_short_Accum_value_cpp_is_trivially_copyable_unsigned_Fract_value_unsigned_short_Accum_type_cpp_bit_cast_unsigned_short_Accum_unsigned_Fract_unsigned_Fract_const
{
	public unsafe static short Invoke(void* from)
	{
		return *unchecked((short*)from);
	}
}
