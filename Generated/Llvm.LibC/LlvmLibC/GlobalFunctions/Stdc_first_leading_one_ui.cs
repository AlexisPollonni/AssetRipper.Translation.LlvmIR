using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_leading_one_ui
{
	[MangledName("stdc_first_leading_one_ui")]
	[DemangledName("stdc_first_leading_one_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return First_leading_one_unsigned_int.Invoke(Value);
	}
}
