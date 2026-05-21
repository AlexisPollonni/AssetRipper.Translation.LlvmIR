using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_has_single_bit_ui
{
	[MangledName("stdc_has_single_bit_ui")]
	[DemangledName("stdc_has_single_bit_ui")]
	public static bool Invoke([MangledName("value")] int Value)
	{
		return Cpp_has_single_bit_unsigned_int.Invoke(Value);
	}
}
