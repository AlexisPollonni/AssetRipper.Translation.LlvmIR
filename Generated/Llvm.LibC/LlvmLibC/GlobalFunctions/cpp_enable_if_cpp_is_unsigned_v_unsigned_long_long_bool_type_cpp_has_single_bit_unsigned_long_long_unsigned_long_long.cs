using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp14has_single_bitIyEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEbE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, bool>::type __llvm_libc_20_1_2_::cpp::has_single_bit<unsigned long long>(unsigned long long)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_long_long_bool_type_cpp_has_single_bit_unsigned_long_long_unsigned_long_long
{
	public static bool Invoke(long value)
	{
		return value != 0L && (value & unchecked(value - 1L)) == 0L;
	}
}
