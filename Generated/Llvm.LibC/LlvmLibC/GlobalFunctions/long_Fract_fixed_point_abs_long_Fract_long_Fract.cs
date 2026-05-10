using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDRlEET_S2_")]
[DemangledName("long _Fract __llvm_libc_20_1_2_::fixed_point::abs<long _Fract>(long _Fract)")]
internal static partial class long_Fract_fixed_point_abs_long_Fract_long_Fract
{
	public static int Invoke(int x)
	{
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(x == fixed_point_FXRep_long_Fract_MIN.Invoke(), expected: false))
		{
			return fixed_point_FXRep_long_Fract_MAX.Invoke();
		}
		return (x >= fixed_point_FXRep_long_Fract_ZERO.Invoke()) ? x : unchecked(-x);
	}
}
