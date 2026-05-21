using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_trailing_ones_ul
{
	[MangledName("stdc_trailing_ones_ul")]
	[DemangledName("stdc_trailing_ones_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_countr_one_unsigned_long.Invoke(Value);
	}
}
