using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_ceil_log10_pow2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal15ceil_log10_pow2Ej")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ceil_log10_pow2(unsigned int)")]
	public static int Invoke([NativeType("unsigned int")] int e)
	{
		return unchecked(internal_log10_pow2.Invoke((uint)e) + 1);
	}
}
