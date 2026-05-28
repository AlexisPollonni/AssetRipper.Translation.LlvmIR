using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_zero_ull
{
	[MangledName("stdc_first_trailing_zero_ull")]
	[DemangledName("stdc_first_trailing_zero_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return First_trailing_zero_unsigned_long_long.Invoke(Value);
	}
}
