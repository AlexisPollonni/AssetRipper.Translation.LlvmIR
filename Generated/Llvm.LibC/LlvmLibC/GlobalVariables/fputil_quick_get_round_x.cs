using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZZN19__llvm_libc_20_1_2_6fputil15quick_get_roundEvE1x")]
[DemangledName("__llvm_libc_20_1_2_::fputil::quick_get_round()::x")]
internal static partial class fputil_quick_get_round_x
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

	static fputil_quick_get_round_x()
	{
		Value = 5.9604645E-08f;
	}
}
