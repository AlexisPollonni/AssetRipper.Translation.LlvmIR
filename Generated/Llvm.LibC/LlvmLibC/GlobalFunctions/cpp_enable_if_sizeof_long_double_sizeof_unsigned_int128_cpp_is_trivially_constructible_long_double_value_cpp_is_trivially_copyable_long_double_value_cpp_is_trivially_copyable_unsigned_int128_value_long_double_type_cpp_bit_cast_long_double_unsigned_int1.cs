using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIeoEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long double) == sizeof (unsigned __int128) && cpp::is_trivially_constructible<long double>::value && cpp::is_trivially_copyable<long double>::value && cpp::is_trivially_copyable<unsigned __int128>::value, long double>::type __llvm_libc_20_1_2_::cpp::bit_cast<long double, unsigned __int128>(unsigned __int128 const&)")]
internal static partial class cpp_enable_if_sizeof_long_double_sizeof_unsigned_int128_cpp_is_trivially_constructible_long_double_value_cpp_is_trivially_copyable_long_double_value_cpp_is_trivially_copyable_unsigned_int128_value_long_double_type_cpp_bit_cast_long_double_unsigned_int128_unsigned_int128_const
{
	public unsafe static double Invoke(void* from)
	{
		return *unchecked((double*)from);
	}
}
