using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDAlEET_S2_")]
[DemangledName("long _Accum __llvm_libc_20_1_2_::fixed_point::abs<long _Accum>(long _Accum)")]
internal static partial class long_Accum_fixed_point_abs_long_Accum_long_Accum
{
	public static long Invoke(long x)
	{
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(x == fixed_point_FXRep_long_Accum_MIN.Invoke(), expected: false))
		{
			return fixed_point_FXRep_long_Accum_MAX.Invoke();
		}
		return (x >= fixed_point_FXRep_long_Accum_ZERO.Invoke()) ? x : unchecked(-x);
	}
}
