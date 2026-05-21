using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_floor_uc
{
	[MangledName("stdc_bit_floor_uc")]
	[DemangledName("stdc_bit_floor_uc")]
	public static sbyte Invoke([MangledName("value")] sbyte Value)
	{
		return Cpp_bit_floor_unsigned_char.Invoke(Value);
	}
}
