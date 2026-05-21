using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_ones_us
{
	[MangledName("stdc_leading_ones_us")]
	[DemangledName("stdc_leading_ones_us")]
	public static int Invoke([MangledName("value")] short Value)
	{
		return Cpp_countl_one_unsigned_short.Invoke(Value);
	}
}
