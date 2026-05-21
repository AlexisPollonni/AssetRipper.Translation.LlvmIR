using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_ones_ull
{
	[MangledName("stdc_leading_ones_ull")]
	[DemangledName("stdc_leading_ones_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_countl_one_unsigned_long_long.Invoke(Value);
	}
}
