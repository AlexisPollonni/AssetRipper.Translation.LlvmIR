using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_leading_zero_ull
{
	[MangledName("stdc_first_leading_zero_ull")]
	[DemangledName("stdc_first_leading_zero_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Llvm_libc_20_1_2_first_leading_zero_unsigned_long_long.Invoke(Value);
	}
}
