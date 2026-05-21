using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_ceil_ull
{
	[MangledName("stdc_bit_ceil_ull")]
	[DemangledName("stdc_bit_ceil_ull")]
	public static long Invoke([MangledName("value")] long Value)
	{
		return Cpp_bit_ceil_unsigned_long_long.Invoke(Value);
	}
}
