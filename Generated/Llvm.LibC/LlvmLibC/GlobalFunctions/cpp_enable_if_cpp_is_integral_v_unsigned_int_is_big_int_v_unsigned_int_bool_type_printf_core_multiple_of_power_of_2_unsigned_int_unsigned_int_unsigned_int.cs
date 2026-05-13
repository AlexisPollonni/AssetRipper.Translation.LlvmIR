using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core22multiple_of_power_of_2IjEENS_3cpp9enable_ifIXoosr3cppE13is_integral_vIT_E12is_big_int_vIS4_EEbE4typeES4_j")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned int> || is_big_int_v<unsigned int>, bool>::type __llvm_libc_20_1_2_::printf_core::multiple_of_power_of_2<unsigned int>(unsigned int, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_unsigned_int_is_big_int_v_unsigned_int_bool_type_printf_core_multiple_of_power_of_2_unsigned_int_unsigned_int_unsigned_int
{
	public static bool Invoke(int value, int p)
	{
		return (value & unchecked((1 << p) - 1)) == 0;
	}
}
