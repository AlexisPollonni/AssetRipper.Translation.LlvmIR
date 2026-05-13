using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core22multiple_of_power_of_2ImEENS_3cpp9enable_ifIXoosr3cppE13is_integral_vIT_E12is_big_int_vIS4_EEbE4typeES4_j")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned long> || is_big_int_v<unsigned long>, bool>::type __llvm_libc_20_1_2_::printf_core::multiple_of_power_of_2<unsigned long>(unsigned long, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_unsigned_long_is_big_int_v_unsigned_long_bool_type_printf_core_multiple_of_power_of_2_unsigned_long_unsigned_long_unsigned_int
{
	public static bool Invoke(long value, int p)
	{
		return (value & unchecked((1L << (int)(uint)p) - 1L)) == 0L;
	}
}
