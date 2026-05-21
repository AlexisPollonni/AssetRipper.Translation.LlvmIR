using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_zeros_us
{
	[MangledName("stdc_leading_zeros_us")]
	[DemangledName("stdc_leading_zeros_us")]
	public static int Invoke([MangledName("value")] short Value)
	{
		return Cpp_countl_zero_unsigned_short.Invoke(Value);
	}
}
