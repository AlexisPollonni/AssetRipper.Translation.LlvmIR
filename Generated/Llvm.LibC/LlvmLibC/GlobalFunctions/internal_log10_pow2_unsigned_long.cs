using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal10log10_pow2Em")]
[DemangledName("__llvm_libc_20_1_2_::internal::log10_pow2(unsigned long)")]
internal static partial class internal_log10_pow2_unsigned_long
{
	public static int Invoke(long e)
	{
		return unchecked((int)(e * 1323943923645L >>> 42));
	}
}
