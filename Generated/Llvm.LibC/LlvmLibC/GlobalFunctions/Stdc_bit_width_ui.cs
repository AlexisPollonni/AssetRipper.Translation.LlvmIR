using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_width_ui
{
	[MangledName("stdc_bit_width_ui")]
	[DemangledName("stdc_bit_width_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return Cpp_bit_width_unsigned_int.Invoke(Value);
	}
}
