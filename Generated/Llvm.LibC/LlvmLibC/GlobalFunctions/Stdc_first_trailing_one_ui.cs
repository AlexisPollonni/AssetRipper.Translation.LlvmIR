using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_one_ui
{
	[MangledName("stdc_first_trailing_one_ui")]
	[DemangledName("stdc_first_trailing_one_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return First_trailing_one_unsigned_int.Invoke(Value);
	}
}
