using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_has_single_bit_uc
{
	[MangledName("stdc_has_single_bit_uc")]
	[DemangledName("stdc_has_single_bit_uc")]
	public static bool Invoke([MangledName("value")] sbyte Value)
	{
		return Cpp_has_single_bit_unsigned_char.Invoke(Value);
	}
}
