using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_leading_zero_us
{
	[MangledName("stdc_first_leading_zero_us")]
	[DemangledName("stdc_first_leading_zero_us")]
	public static int Invoke([MangledName("value")] short Value)
	{
		return Llvm_libc_20_1_2_first_leading_zero_unsigned_short.Invoke(Value);
	}
}
