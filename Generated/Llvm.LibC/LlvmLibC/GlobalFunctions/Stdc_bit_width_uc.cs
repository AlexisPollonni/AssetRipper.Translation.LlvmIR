using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_width_uc
{
	[MangledName("stdc_bit_width_uc")]
	[DemangledName("stdc_bit_width_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return Cpp_bit_width_unsigned_char.Invoke(Value);
	}
}
