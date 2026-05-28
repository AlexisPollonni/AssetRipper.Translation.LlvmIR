using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_leading_one_uc
{
	[MangledName("stdc_first_leading_one_uc")]
	[DemangledName("stdc_first_leading_one_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return First_leading_one_unsigned_char.Invoke(Value);
	}
}
