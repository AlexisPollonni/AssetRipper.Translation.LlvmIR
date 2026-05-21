using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_width_ul
{
	[MangledName("stdc_bit_width_ul")]
	[DemangledName("stdc_bit_width_ul")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Cpp_bit_width_unsigned_long.Invoke(Value);
	}
}
