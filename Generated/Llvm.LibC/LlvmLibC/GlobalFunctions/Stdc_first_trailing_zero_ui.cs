using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_zero_ui
{
	[MangledName("stdc_first_trailing_zero_ui")]
	[DemangledName("stdc_first_trailing_zero_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return Llvm_libc_20_1_2_first_trailing_zero_unsigned_int.Invoke(Value);
	}
}
