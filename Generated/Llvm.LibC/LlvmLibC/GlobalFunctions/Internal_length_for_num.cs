using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_length_for_num
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal14length_for_numEjj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::length_for_num(unsigned int, unsigned int)")]
	public static int Invoke([MangledName("idx")][NativeType("unsigned int")] int Idx, [MangledName("mantissa_width")][NativeType("unsigned int")] int Mantissa_width)
	{
		return Internal_div_ceil.Invoke(unchecked(Internal_ceil_log10_pow2.Invoke(Idx) + Internal_ceil_log10_pow2.Invoke(Mantissa_width + 1)), 9);
	}
}
