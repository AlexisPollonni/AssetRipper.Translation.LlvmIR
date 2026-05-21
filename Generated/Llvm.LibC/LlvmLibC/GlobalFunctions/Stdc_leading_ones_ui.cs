using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_ones_ui
{
	[MangledName("stdc_leading_ones_ui")]
	[DemangledName("stdc_leading_ones_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return Cpp_countl_one_unsigned_int.Invoke(Value);
	}
}
