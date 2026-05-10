using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp10countl_oneIjEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::cpp::countl_one<unsigned int>(unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countl_one_unsigned_int_unsigned_int
{
	public static int Invoke(int value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countl_zero_unsigned_int_unsigned_int.Invoke(value ^ -1);
	}
}
