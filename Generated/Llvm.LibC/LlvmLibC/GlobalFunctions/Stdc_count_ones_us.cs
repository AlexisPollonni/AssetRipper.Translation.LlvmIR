using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_ones_us
{
	[MangledName("stdc_count_ones_us")]
	[DemangledName("stdc_count_ones_us")]
	public static int Invoke([MangledName("value")] short Value)
	{
		return Cpp_popcount_unsigned_short.Invoke(Value);
	}
}
