using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_zeros_uc
{
	[MangledName("stdc_count_zeros_uc")]
	[DemangledName("stdc_count_zeros_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return Count_zeros_unsigned_char.Invoke(Value);
	}
}
