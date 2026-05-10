using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIldEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long) == sizeof (double) && cpp::is_trivially_constructible<long>::value && cpp::is_trivially_copyable<long>::value && cpp::is_trivially_copyable<double>::value, long>::type __llvm_libc_20_1_2_::cpp::bit_cast<long, double>(double const&)")]
internal static partial class cpp_enable_if_sizeof_long_sizeof_double_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_double_value_long_type_cpp_bit_cast_long_double_double_const
{
	public unsafe static long Invoke(void* from)
	{
		return *unchecked((long*)from);
	}
}
