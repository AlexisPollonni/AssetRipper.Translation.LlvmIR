using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Stdc_first_trailing_one_ull
{
	[MangledName("stdc_first_trailing_one_ull")]
	[DemangledName("stdc_first_trailing_one_ull")]
	public static int Invoke([MangledName("value")] long Value)
	{
		return Llvm_libc_20_1_2_first_trailing_one_unsigned_long_long.Invoke(Value);
	}
}
