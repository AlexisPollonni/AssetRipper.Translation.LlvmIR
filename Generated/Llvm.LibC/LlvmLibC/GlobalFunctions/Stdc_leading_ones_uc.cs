using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_ones_uc
{
	[MangledName("stdc_leading_ones_uc")]
	[DemangledName("stdc_leading_ones_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return Cpp_countl_one_unsigned_char.Invoke(Value);
	}
}
