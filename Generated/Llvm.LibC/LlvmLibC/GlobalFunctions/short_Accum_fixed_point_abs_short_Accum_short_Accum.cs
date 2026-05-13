using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDAsEET_S2_")]
[DemangledName("short _Accum __llvm_libc_20_1_2_::fixed_point::abs<short _Accum>(short _Accum)")]
internal static partial class short_Accum_fixed_point_abs_short_Accum_short_Accum
{
	public static short Invoke(short x)
	{
		short num = x;
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == fixed_point_FXRep_short_Accum_MIN.Invoke(), expected: false))
		{
			return fixed_point_FXRep_short_Accum_MAX.Invoke();
		}
		return unchecked((short)((num >= fixed_point_FXRep_short_Accum_ZERO.Invoke()) ? num : (-num)));
	}
}
