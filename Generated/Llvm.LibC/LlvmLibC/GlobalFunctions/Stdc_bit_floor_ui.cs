using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_floor_ui
{
	[MangledName("stdc_bit_floor_ui")]
	[DemangledName("stdc_bit_floor_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return Cpp_bit_floor_unsigned_int.Invoke(Value);
	}
}
