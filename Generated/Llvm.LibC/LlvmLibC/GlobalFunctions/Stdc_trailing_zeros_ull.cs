using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_trailing_zeros_ull
{
	[MangledName("stdc_trailing_zeros_ull")]
	[DemangledName("stdc_trailing_zeros_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_countr_zero_unsigned_long_long.Invoke(Value);
	}
}
