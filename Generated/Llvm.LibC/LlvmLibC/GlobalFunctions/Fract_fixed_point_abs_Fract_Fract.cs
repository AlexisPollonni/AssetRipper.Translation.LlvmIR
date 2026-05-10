using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDRiEET_S2_")]
[DemangledName("_Fract __llvm_libc_20_1_2_::fixed_point::abs<_Fract>(_Fract)")]
internal static partial class Fract_fixed_point_abs_Fract_Fract
{
	public static short Invoke(short x)
	{
		short num = x;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == fixed_point_FXRep_Fract_MIN.Invoke(), expected: false))
		{
			return fixed_point_FXRep_Fract_MAX.Invoke();
		}
		return unchecked((short)((num >= fixed_point_FXRep_Fract_ZERO.Invoke()) ? num : (-num)));
	}
}
