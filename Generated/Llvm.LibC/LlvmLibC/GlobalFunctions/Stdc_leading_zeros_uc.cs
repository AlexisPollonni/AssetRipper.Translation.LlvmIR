using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_zeros_uc
{
	[MangledName("stdc_leading_zeros_uc")]
	[DemangledName("stdc_leading_zeros_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return Cpp_countl_zero_unsigned_char.Invoke(Value);
	}
}
