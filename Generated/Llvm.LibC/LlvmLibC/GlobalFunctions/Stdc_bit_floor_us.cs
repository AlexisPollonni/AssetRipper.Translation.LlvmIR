using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_floor_us
{
	[MangledName("stdc_bit_floor_us")]
	[DemangledName("stdc_bit_floor_us")]
	public static short Invoke([MangledName("value")] short Value)
	{
		return Cpp_bit_floor_unsigned_short.Invoke(Value);
	}
}
