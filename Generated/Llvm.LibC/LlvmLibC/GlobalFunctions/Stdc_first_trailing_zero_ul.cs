using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_zero_ul
{
	[MangledName("stdc_first_trailing_zero_ul")]
	[DemangledName("stdc_first_trailing_zero_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Llvm_libc_20_1_2_first_trailing_zero_unsigned_long.Invoke(Value);
	}
}
