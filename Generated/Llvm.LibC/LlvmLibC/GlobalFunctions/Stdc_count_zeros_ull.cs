using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_zeros_ull
{
	[MangledName("stdc_count_zeros_ull")]
	[DemangledName("stdc_count_zeros_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Llvm_libc_20_1_2_count_zeros_unsigned_long_long.Invoke(Value);
	}
}
