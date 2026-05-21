using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_has_single_bit_us
{
	[MangledName("stdc_has_single_bit_us")]
	[DemangledName("stdc_has_single_bit_us")]
	public static bool Invoke([MangledName("value")] short Value)
	{
		return Cpp_has_single_bit_unsigned_short.Invoke(Value);
	}
}
