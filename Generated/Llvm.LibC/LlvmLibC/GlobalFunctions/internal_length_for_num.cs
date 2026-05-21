using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_length_for_num
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal14length_for_numEjj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::length_for_num(unsigned int, unsigned int)")]
	public static int Invoke([NativeType("unsigned int")] int idx, [NativeType("unsigned int")] int mantissa_width)
	{
		return internal_div_ceil.Invoke(unchecked(internal_ceil_log10_pow2.Invoke(idx) + internal_ceil_log10_pow2.Invoke(mantissa_width + 1)), 9);
	}
}
