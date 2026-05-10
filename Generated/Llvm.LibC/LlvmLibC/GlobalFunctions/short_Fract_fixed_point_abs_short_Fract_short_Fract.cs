using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDRsEET_S2_")]
[DemangledName("short _Fract __llvm_libc_20_1_2_::fixed_point::abs<short _Fract>(short _Fract)")]
internal static partial class short_Fract_fixed_point_abs_short_Fract_short_Fract
{
	public static sbyte Invoke(sbyte x)
	{
		sbyte b = x;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(b == fixed_point_FXRep_short_Fract_MIN.Invoke(), expected: false))
		{
			return fixed_point_FXRep_short_Fract_MAX.Invoke();
		}
		return unchecked((sbyte)((b >= fixed_point_FXRep_short_Fract_ZERO.Invoke()) ? b : (-b)));
	}
}
