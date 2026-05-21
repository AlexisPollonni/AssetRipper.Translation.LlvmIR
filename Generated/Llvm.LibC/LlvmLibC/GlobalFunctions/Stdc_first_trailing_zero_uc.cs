using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_zero_uc
{
	[MangledName("stdc_first_trailing_zero_uc")]
	[DemangledName("stdc_first_trailing_zero_uc")]
	public static int Invoke([MangledName("value")] sbyte Value)
	{
		return Llvm_libc_20_1_2_first_trailing_zero_unsigned_char.Invoke(Value);
	}
}
