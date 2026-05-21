using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_ceil_us
{
	[MangledName("stdc_bit_ceil_us")]
	[DemangledName("stdc_bit_ceil_us")]
	public static short Invoke([MangledName("value")] short Value)
	{
		return Cpp_bit_ceil_unsigned_short.Invoke(Value);
	}
}
