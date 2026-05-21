using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_div_ceil
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8div_ceilEjj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::div_ceil(unsigned int, unsigned int)")]
	public static int Invoke([MangledName("num")][NativeType("unsigned int")] int Num, [MangledName("denom")][NativeType("unsigned int")] int Denom)
	{
		return unchecked((int)((uint)(Num + (Denom - 1)) / (uint)Denom));
	}
}
