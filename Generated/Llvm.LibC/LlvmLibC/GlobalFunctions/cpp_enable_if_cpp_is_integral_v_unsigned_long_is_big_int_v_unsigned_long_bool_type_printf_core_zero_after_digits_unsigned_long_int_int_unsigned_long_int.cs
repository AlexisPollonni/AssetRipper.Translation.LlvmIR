using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core17zero_after_digitsImEENS_3cpp9enable_ifIXoosr3cppE13is_integral_vIT_E12is_big_int_vIS4_EEbE4typeEiiS4_i")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned long> || is_big_int_v<unsigned long>, bool>::type __llvm_libc_20_1_2_::printf_core::zero_after_digits<unsigned long>(int, int, unsigned long, int)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_unsigned_long_is_big_int_v_unsigned_long_bool_type_printf_core_zero_after_digits_unsigned_long_int_int_unsigned_long_int
{
	public unsafe static bool Invoke(int base_2_exp, int digits_after_point, long mantissa, int mant_width)
	{
		int num = 0;
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -base_2_exp - digits_after_point - 1;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (sbyte)(byte)((num <= 0) ? (-1) : ((num < checked(mant_width + 8) && cpp_enable_if_cpp_is_integral_v_unsigned_long_is_big_int_v_unsigned_long_bool_type_printf_core_multiple_of_power_of_2_unsigned_long_unsigned_long_unsigned_int.Invoke(mantissa, num)) ? 1 : 0));
			bool result = (b & 1) == 1;
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
