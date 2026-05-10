using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal14length_for_numEjj")]
[DemangledName("__llvm_libc_20_1_2_::internal::length_for_num(unsigned int, unsigned int)")]
internal static partial class internal_length_for_num_unsigned_int_unsigned_int
{
	public static int Invoke(int idx, int mantissa_width)
	{
		return internal_div_ceil_unsigned_int_unsigned_int.Invoke(unchecked(internal_ceil_log10_pow2_unsigned_int.Invoke(idx) + internal_ceil_log10_pow2_unsigned_int.Invoke(mantissa_width + 1)), 9);
	}
}
