using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_18first_leading_zeroIyEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, int>::type __llvm_libc_20_1_2_::first_leading_zero<unsigned long long>(unsigned long long)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_long_long_int_type_first_leading_zero_unsigned_long_long_unsigned_long_long
{
	public static int Invoke(long value)
	{
		return (value != cpp_internal_integer_impl_unsigned_long_long_0ull_18446744073709551615ull_max.Invoke()) ? (cpp_enable_if_cpp_is_unsigned_v_unsigned_long_long_int_type_cpp_countl_one_unsigned_long_long_unsigned_long_long.Invoke(value) + 1) : 0;
	}
}
