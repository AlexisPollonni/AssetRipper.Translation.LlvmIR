using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_zeros_ul
{
	[MangledName("stdc_count_zeros_ul")]
	[DemangledName("stdc_count_zeros_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Llvm_libc_20_1_2_count_zeros_unsigned_long.Invoke(Value);
	}
}
