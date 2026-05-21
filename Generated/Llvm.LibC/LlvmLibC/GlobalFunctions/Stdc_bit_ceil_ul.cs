using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_ceil_ul
{
	[MangledName("stdc_bit_ceil_ul")]
	[DemangledName("stdc_bit_ceil_ul")]
	public static long Invoke([MangledName("value")] long Value)
	{
		return Cpp_bit_ceil_unsigned_long.Invoke(Value);
	}
}
