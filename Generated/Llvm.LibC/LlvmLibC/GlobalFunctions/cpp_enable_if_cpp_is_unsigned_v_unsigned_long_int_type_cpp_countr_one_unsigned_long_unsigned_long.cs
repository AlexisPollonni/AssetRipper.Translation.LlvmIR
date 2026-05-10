using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp10countr_oneImEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type __llvm_libc_20_1_2_::cpp::countr_one<unsigned long>(unsigned long)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countr_one_unsigned_long_unsigned_long
{
	public static int Invoke(long value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countr_zero_unsigned_long_unsigned_long.Invoke(value ^ -1L);
	}
}
