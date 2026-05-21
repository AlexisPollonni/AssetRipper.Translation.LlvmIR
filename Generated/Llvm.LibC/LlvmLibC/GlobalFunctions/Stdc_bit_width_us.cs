using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_width_us
{
	[MangledName("stdc_bit_width_us")]
	[DemangledName("stdc_bit_width_us")]
	public static int Invoke([MangledName("value")] short Value)
	{
		return Cpp_bit_width_unsigned_short.Invoke(Value);
	}
}
