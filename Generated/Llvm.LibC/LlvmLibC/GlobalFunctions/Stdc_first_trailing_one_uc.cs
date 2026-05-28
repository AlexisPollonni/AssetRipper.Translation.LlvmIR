using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_one_uc
{
	[MangledName("stdc_first_trailing_one_uc")]
	[DemangledName("stdc_first_trailing_one_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return First_trailing_one_unsigned_char.Invoke(Value);
	}
}
