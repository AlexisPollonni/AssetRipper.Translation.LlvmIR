using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_trailing_ones_ui
{
	[MangledName("stdc_trailing_ones_ui")]
	[DemangledName("stdc_trailing_ones_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return Cpp_countr_one_unsigned_int.Invoke(Value);
	}
}
