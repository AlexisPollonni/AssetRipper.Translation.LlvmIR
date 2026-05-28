using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_leading_zero_ul
{
	[MangledName("stdc_first_leading_zero_ul")]
	[DemangledName("stdc_first_leading_zero_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return First_leading_zero_unsigned_long.Invoke(Value);
	}
}
