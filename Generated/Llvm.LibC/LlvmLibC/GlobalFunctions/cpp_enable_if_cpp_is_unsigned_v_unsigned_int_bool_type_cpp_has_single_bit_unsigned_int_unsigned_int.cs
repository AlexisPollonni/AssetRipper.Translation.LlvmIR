using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp14has_single_bitIjEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEbE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, bool>::type __llvm_libc_20_1_2_::cpp::has_single_bit<unsigned int>(unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_int_bool_type_cpp_has_single_bit_unsigned_int_unsigned_int
{
	public static bool Invoke(int value)
	{
		return value != 0 && (value & unchecked(value - 1)) == 0;
	}
}
