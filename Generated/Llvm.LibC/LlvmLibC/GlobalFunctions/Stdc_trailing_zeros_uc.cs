using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_trailing_zeros_uc
{
	[MangledName("stdc_trailing_zeros_uc")]
	[DemangledName("stdc_trailing_zeros_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return Cpp_countr_zero_unsigned_char.Invoke(Value);
	}
}
