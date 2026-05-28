using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_leading_one_ull
{
	[MangledName("stdc_first_leading_one_ull")]
	[DemangledName("stdc_first_leading_one_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return First_leading_one_unsigned_long_long.Invoke(Value);
	}
}
