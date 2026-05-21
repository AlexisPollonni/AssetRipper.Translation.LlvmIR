using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_leading_zeros_ull
{
	[MangledName("stdc_leading_zeros_ull")]
	[DemangledName("stdc_leading_zeros_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_countl_zero_unsigned_long_long.Invoke(Value);
	}
}
