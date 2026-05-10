using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_floorIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, unsigned char>::type __llvm_libc_20_1_2_::cpp::bit_floor<unsigned char>(unsigned char)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_char_unsigned_char_type_cpp_bit_floor_unsigned_char_unsigned_char
{
	public static sbyte Invoke(sbyte value)
	{
		sbyte b = value;
		if (b == 0)
		{
			return 0;
		}
		unchecked
		{
			return (sbyte)(1 << checked(cpp_enable_if_cpp_is_unsigned_v_unsigned_char_int_type_cpp_bit_width_unsigned_char_unsigned_char.Invoke(b) - 1));
		}
	}
}
