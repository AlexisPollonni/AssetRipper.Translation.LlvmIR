using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_ones_ul
{
	[MangledName("stdc_count_ones_ul")]
	[DemangledName("stdc_count_ones_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_popcount_unsigned_long.Invoke(Value);
	}
}
