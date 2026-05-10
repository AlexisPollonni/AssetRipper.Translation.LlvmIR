using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_floorItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, unsigned short>::type __llvm_libc_20_1_2_::cpp::bit_floor<unsigned short>(unsigned short)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_short_unsigned_short_type_cpp_bit_floor_unsigned_short_unsigned_short
{
	public static short Invoke(short value)
	{
		short num = value;
		if (num == 0)
		{
			return 0;
		}
		unchecked
		{
			return (short)(1 << checked(cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_cpp_bit_width_unsigned_short_unsigned_short.Invoke(num) - 1));
		}
	}
}
