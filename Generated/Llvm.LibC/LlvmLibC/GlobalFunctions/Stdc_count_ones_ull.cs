using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_ones_ull
{
	[MangledName("stdc_count_ones_ull")]
	[DemangledName("stdc_count_ones_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_popcount_unsigned_long_long.Invoke(Value);
	}
}
