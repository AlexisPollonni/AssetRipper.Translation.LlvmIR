using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_has_single_bit_ull
{
	[MangledName("stdc_has_single_bit_ull")]
	[DemangledName("stdc_has_single_bit_ull")]
	public static bool Invoke([MangledName("value")] long Value)
	{
		return Cpp_has_single_bit_unsigned_long_long.Invoke(Value);
	}
}
