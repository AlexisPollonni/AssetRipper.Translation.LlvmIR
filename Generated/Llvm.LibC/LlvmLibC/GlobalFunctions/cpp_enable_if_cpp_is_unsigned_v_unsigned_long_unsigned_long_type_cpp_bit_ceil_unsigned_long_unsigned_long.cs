using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_ceilImEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, unsigned long>::type __llvm_libc_20_1_2_::cpp::bit_ceil<unsigned long>(unsigned long)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_long_unsigned_long_type_cpp_bit_ceil_unsigned_long_unsigned_long
{
	public static long Invoke(long value)
	{
		unchecked
		{
			if ((ulong)value < 2uL)
			{
				return 1L;
			}
			return 1L << (int)(uint)cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_bit_width_unsigned_long_unsigned_long.Invoke(value - 1L);
		}
	}
}
