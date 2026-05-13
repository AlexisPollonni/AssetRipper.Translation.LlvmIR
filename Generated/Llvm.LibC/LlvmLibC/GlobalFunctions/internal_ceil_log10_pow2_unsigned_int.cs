using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal15ceil_log10_pow2Ej")]
[DemangledName("__llvm_libc_20_1_2_::internal::ceil_log10_pow2(unsigned int)")]
internal static partial class internal_ceil_log10_pow2_unsigned_int
{
	public static int Invoke(int e)
	{
		return unchecked(internal_log10_pow2_unsigned_long.Invoke((uint)e) + 1);
	}
}
