using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_ceil_log10_pow2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal15ceil_log10_pow2Ej")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ceil_log10_pow2(unsigned int)")]
	public static int Invoke([MangledName("e")][NativeType("unsigned int")] int E)
	{
		return unchecked(Internal_log10_pow2.Invoke((uint)E) + 1);
	}
}
