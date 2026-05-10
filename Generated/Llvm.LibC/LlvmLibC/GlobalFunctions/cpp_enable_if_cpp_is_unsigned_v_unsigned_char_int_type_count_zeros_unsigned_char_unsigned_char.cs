using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11count_zerosIhEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::count_zeros<unsigned char>(unsigned char)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_char_int_type_count_zeros_unsigned_char_unsigned_char
{
	public static int Invoke(sbyte value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_char_int_type_cpp_popcount_unsigned_char_unsigned_char.Invoke(unchecked((sbyte)((byte)value ^ -1)));
	}
}
