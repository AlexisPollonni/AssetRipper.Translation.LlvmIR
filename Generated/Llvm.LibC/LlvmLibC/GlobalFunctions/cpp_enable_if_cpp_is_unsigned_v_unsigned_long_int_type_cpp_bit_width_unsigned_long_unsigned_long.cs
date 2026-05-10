using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_widthImEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type __llvm_libc_20_1_2_::cpp::bit_width<unsigned long>(unsigned long)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_bit_width_unsigned_long_unsigned_long
{
	public static int Invoke(long value)
	{
		return 64 - cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countl_zero_unsigned_long_unsigned_long.Invoke(value);
	}
}
