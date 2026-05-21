using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_ilog2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal5ilog2Em")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ilog2(unsigned long)")]
	public static long Invoke([MangledName("n")][NativeType("unsigned long")] long N)
	{
		return Cpp_bit_width_unsigned_long.Invoke(N) - 1;
	}
}
