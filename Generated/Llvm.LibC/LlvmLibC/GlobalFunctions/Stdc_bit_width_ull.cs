using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_width_ull
{
	[MangledName("stdc_bit_width_ull")]
	[DemangledName("stdc_bit_width_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_bit_width_unsigned_long_long.Invoke(Value);
	}
}
