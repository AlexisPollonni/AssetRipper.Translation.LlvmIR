using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core17zero_after_digitsIoEENS_3cpp9enable_ifIXoosr3cppE13is_integral_vIT_E12is_big_int_vIS4_EEbE4typeEiiS4_i")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned __int128> || is_big_int_v<unsigned __int128>, bool>::type __llvm_libc_20_1_2_::printf_core::zero_after_digits<unsigned __int128>(int, int, unsigned __int128, int)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_unsigned_int128_is_big_int_v_unsigned_int128_bool_type_printf_core_zero_after_digits_unsigned_int128_int_int_unsigned_int128_int
{
	public unsafe static bool Invoke(int base_2_exp, int digits_after_point, [MangledName("mantissa.coerce0")] long mantissa, [MangledName("mantissa.coerce1")] long mant_width, [MangledName("mant_width")] int required_twos)
	{
		Int128 @int = default(Int128);
		int num = 0;
		sbyte b = 0;
		Int128 int2 = default(Int128);
		unchecked
		{
			*(long*)(&@int) = mantissa;
			((long*)(&@int))[1] = mant_width;
			Int128 int3 = @int;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = checked(-base_2_exp - digits_after_point - 1);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			int num2;
			if (num <= 0)
			{
				num2 = -1;
			}
			else if (num >= checked(required_twos + 8))
			{
				num2 = 0;
			}
			else
			{
				int p_42n5rb = num;
				int2 = int3;
				num2 = (cpp_enable_if_cpp_is_integral_v_unsigned_int128_is_big_int_v_unsigned_int128_bool_type_printf_core_multiple_of_power_of_2_unsigned_int128_unsigned_int128_unsigned_int.Invoke(*(long*)(&int2), ((long*)(&int2))[1], p_42n5rb) ? 1 : 0);
			}
			b = (sbyte)(byte)num2;
			bool result = (b & 1) == 1;
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
