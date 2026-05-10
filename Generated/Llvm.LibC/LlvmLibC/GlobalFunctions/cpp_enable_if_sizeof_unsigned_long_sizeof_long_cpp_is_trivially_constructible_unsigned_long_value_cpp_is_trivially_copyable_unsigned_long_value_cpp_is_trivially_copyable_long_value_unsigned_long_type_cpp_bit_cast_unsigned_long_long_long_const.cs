using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castImlEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned long) == sizeof (long) && cpp::is_trivially_constructible<unsigned long>::value && cpp::is_trivially_copyable<unsigned long>::value && cpp::is_trivially_copyable<long>::value, unsigned long>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned long, long>(long const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_long_sizeof_long_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_long_value_unsigned_long_type_cpp_bit_cast_unsigned_long_long_long_const
{
	public unsafe static long Invoke(void* from)
	{
		return *unchecked((long*)from);
	}
}
