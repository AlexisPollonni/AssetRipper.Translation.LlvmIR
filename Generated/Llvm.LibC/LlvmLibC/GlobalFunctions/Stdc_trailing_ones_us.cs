using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_trailing_ones_us
{
	[MangledName("stdc_trailing_ones_us")]
	[DemangledName("stdc_trailing_ones_us")]
	public static int Invoke([MangledName("value")] short Value)
	{
		return Cpp_countr_one_unsigned_short.Invoke(Value);
	}
}
