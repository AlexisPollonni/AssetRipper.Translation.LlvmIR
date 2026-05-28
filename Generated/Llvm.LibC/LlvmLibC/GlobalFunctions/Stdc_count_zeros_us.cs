using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_zeros_us
{
	[MangledName("stdc_count_zeros_us")]
	[DemangledName("stdc_count_zeros_us")]
	public static int Invoke([MangledName("value")] short Value)
	{
		return Count_zeros_unsigned_short.Invoke(Value);
	}
}
