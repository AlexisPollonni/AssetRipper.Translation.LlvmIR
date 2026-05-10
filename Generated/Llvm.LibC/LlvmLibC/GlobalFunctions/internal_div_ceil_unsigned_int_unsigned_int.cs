using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal8div_ceilEjj")]
[DemangledName("__llvm_libc_20_1_2_::internal::div_ceil(unsigned int, unsigned int)")]
internal static partial class internal_div_ceil_unsigned_int_unsigned_int
{
	public static int Invoke(int num, int denom)
	{
		return unchecked((int)((uint)(num + (denom - 1)) / (uint)denom));
	}
}
