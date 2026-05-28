using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_one_ul
{
	[MangledName("stdc_first_trailing_one_ul")]
	[DemangledName("stdc_first_trailing_one_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return First_trailing_one_unsigned_long.Invoke(Value);
	}
}
