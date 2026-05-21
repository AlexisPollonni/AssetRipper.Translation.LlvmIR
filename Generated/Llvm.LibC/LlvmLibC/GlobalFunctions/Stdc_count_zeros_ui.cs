using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_count_zeros_ui
{
	[MangledName("stdc_count_zeros_ui")]
	[DemangledName("stdc_count_zeros_ui")]
	public static int Invoke([MangledName("value")] int Value)
	{
		return Llvm_libc_20_1_2_count_zeros_unsigned_int.Invoke(Value);
	}
}
