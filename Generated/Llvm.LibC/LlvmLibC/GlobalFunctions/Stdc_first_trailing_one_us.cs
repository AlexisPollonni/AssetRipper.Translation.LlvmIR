using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_one_us
{
	[MangledName("stdc_first_trailing_one_us")]
	[DemangledName("stdc_first_trailing_one_us")]
	public static int Invoke([MangledName("value")] short Value)
	{
		return First_trailing_one_unsigned_short.Invoke(Value);
	}
}
