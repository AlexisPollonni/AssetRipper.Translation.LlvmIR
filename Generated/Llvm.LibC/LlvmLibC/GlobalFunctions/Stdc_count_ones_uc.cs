using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_ones_uc
{
	[MangledName("stdc_count_ones_uc")]
	[DemangledName("stdc_count_ones_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return Cpp_popcount_unsigned_char.Invoke(Value);
	}
}
