using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal5ilog2Em")]
[DemangledName("__llvm_libc_20_1_2_::internal::ilog2(unsigned long)")]
internal static partial class internal_ilog2_unsigned_long
{
	public static long Invoke(long n)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_bit_width_unsigned_long_unsigned_long.Invoke(n) - 1;
	}
}
