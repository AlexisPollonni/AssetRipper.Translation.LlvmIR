using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_floorIyEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, unsigned long long>::type __llvm_libc_20_1_2_::cpp::bit_floor<unsigned long long>(unsigned long long)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_long_long_unsigned_long_long_type_cpp_bit_floor_unsigned_long_long_unsigned_long_long
{
	public static long Invoke(long value)
	{
		if (value == 0L)
		{
			return 0L;
		}
		unchecked
		{
			return 1L << (int)(uint)checked(cpp_enable_if_cpp_is_unsigned_v_unsigned_long_long_int_type_cpp_bit_width_unsigned_long_long_unsigned_long_long.Invoke(value) - 1);
		}
	}
}
