using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_bit_ceil_ui
{
	[MangledName("stdc_bit_ceil_ui")]
	[DemangledName("stdc_bit_ceil_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return Cpp_bit_ceil_unsigned_int.Invoke(Value);
	}
}
