using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_div_ceil
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8div_ceilEjj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::div_ceil(unsigned int, unsigned int)")]
	public static int Invoke([NativeType("unsigned int")] int num, [NativeType("unsigned int")] int denom)
	{
		return unchecked((int)((uint)(num + (denom - 1)) / (uint)denom));
	}
}
