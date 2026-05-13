using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDF16_tEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Float16) == sizeof (unsigned short) && cpp::is_trivially_constructible<_Float16>::value && cpp::is_trivially_copyable<_Float16>::value && cpp::is_trivially_copyable<unsigned short>::value, _Float16>::type __llvm_libc_20_1_2_::cpp::bit_cast<_Float16, unsigned short>(unsigned short const&)")]
internal static partial class cpp_enable_if_sizeof_Float16_sizeof_unsigned_short_cpp_is_trivially_constructible_Float16_value_cpp_is_trivially_copyable_Float16_value_cpp_is_trivially_copyable_unsigned_short_value_Float16_type_cpp_bit_cast_Float16_unsigned_short_unsigned_short_const
{
	public unsafe static Half Invoke(void* from)
	{
		return *unchecked((Half*)from);
	}
}
