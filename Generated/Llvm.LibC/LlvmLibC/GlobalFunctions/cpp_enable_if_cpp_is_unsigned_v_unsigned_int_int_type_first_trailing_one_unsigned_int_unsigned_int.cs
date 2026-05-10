using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_18first_trailing_oneIjEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::first_trailing_one<unsigned int>(unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_first_trailing_one_unsigned_int_unsigned_int
{
	public static int Invoke(int value)
	{
		return (value != cpp_internal_integer_impl_unsigned_int_0u_4294967295u_max.Invoke()) ? (cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countr_zero_unsigned_int_unsigned_int.Invoke(value) + 1) : 0;
	}
}
