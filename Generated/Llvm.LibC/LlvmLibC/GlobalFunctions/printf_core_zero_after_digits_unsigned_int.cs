using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class printf_core_zero_after_digits_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core17zero_after_digitsIjEENS_3cpp9enable_ifIXoosr3cppE13is_integral_vIT_E12is_big_int_vIS4_EEbE4typeEiiS4_i")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned int> || is_big_int_v<unsigned int>, bool>::type __llvm_libc_20_1_2_::printf_core::zero_after_digits<unsigned int>(int, int, unsigned int, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned int> || is_big_int_v<unsigned int>, bool>::type")]
	public unsafe static bool Invoke([NativeType("int")] int base_2_exp, [NativeType("int")] int digits_after_point, [NativeType("unsigned int")] int mantissa, [NativeType("int")] int mant_width)
	{
		int num = 0;
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -base_2_exp - digits_after_point - 1;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			b = (sbyte)(byte)((num <= 0) ? (-1) : ((num < checked(mant_width + 8) && printf_core_multiple_of_power_of_2_unsigned_int.Invoke(mantissa, num)) ? 1 : 0));
			bool result = (b & 1) == 1;
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
