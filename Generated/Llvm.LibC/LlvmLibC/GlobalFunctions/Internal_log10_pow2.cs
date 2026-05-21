using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_log10_pow2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal10log10_pow2Em")]
	[DemangledName("__llvm_libc_20_1_2_::internal::log10_pow2(unsigned long)")]
	public static int Invoke([MangledName("e")][NativeType("unsigned long")] long E)
	{
		return unchecked((int)(E * 1323943923645L >>> 42));
	}
}
