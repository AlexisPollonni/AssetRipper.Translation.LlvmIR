using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_zero_after_digits_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core17zero_after_digitsImEENS_3cpp9enable_ifIXoosr3cppE13is_integral_vIT_E12is_big_int_vIS4_EEbE4typeEiiS4_i")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned long> || is_big_int_v<unsigned long>, bool>::type __llvm_libc_20_1_2_::printf_core::zero_after_digits<unsigned long>(int, int, unsigned long, int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned long> || is_big_int_v<unsigned long>, bool>::type")]
	public unsafe static bool Invoke([MangledName("base_2_exp")][NativeType("int")] int Base_2_exp, [MangledName("digits_after_point")][NativeType("int")] int Digits_after_point, [MangledName("mantissa")][NativeType("unsigned long")] long Mantissa, [MangledName("mant_width")][NativeType("int")] int Mant_width)
	{
		int num = 0;
		sbyte b = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -Base_2_exp - Digits_after_point - 1;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = ((num <= 0 || (num < Mant_width + 8 && Printf_core_multiple_of_power_of_2_unsigned_long.Invoke(Mantissa, num))) ? ((sbyte)1) : ((sbyte)0));
		bool result = (b & 1) == 1;
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
