using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_ilog2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal5ilog2Em")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ilog2(unsigned long)")]
	public static long Invoke([NativeType("unsigned long")] long n)
	{
		return cpp_bit_width_unsigned_long.Invoke(n) - 1;
	}
}
