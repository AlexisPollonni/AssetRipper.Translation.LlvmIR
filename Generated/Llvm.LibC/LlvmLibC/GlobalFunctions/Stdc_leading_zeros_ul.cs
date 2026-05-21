using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_zeros_ul
{
	[MangledName("stdc_leading_zeros_ul")]
	[DemangledName("stdc_leading_zeros_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_countl_zero_unsigned_long.Invoke(Value);
	}
}
