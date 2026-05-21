using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_trailing_ones_uc
{
	[MangledName("stdc_trailing_ones_uc")]
	[DemangledName("stdc_trailing_ones_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return Cpp_countr_one_unsigned_char.Invoke(Value);
	}
}
