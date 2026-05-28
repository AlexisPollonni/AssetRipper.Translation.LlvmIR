using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_6fputil24fenv_is_round_to_nearestEvE1x")]
[DemangledName("__llvm_libc_20_1_2_::fputil::fenv_is_round_to_nearest()::x")]
internal static partial class Fputil_fenv_is_round_to_nearest_x
{
	private static float __value;

	public static float Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	static Fputil_fenv_is_round_to_nearest_x()
	{
		Value = 5.9604645E-08f;
	}
}
