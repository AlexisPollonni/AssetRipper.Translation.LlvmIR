using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_ones_ui
{
	[MangledName("stdc_count_ones_ui")]
	[DemangledName("stdc_count_ones_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return Cpp_popcount_unsigned_int.Invoke(Value);
	}
}
