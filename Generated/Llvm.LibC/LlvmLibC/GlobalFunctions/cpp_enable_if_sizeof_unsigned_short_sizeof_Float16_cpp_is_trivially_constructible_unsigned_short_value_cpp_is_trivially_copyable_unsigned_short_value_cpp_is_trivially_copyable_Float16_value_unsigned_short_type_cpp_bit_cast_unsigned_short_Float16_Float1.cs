using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castItDF16_EENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned short) == sizeof (_Float16) && cpp::is_trivially_constructible<unsigned short>::value && cpp::is_trivially_copyable<unsigned short>::value && cpp::is_trivially_copyable<_Float16>::value, unsigned short>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned short, _Float16>(_Float16 const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_short_sizeof_Float16_cpp_is_trivially_constructible_unsigned_short_value_cpp_is_trivially_copyable_unsigned_short_value_cpp_is_trivially_copyable_Float16_value_unsigned_short_type_cpp_bit_cast_unsigned_short_Float16_Float16_const
{
	public unsafe static short Invoke(void* from)
	{
		return *unchecked((short*)from);
	}
}
