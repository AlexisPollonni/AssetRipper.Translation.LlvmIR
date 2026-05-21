using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_ones_ul
{
	[MangledName("stdc_leading_ones_ul")]
	[DemangledName("stdc_leading_ones_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_countl_one_unsigned_long.Invoke(Value);
	}
}
