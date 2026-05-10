using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDAiEET_S2_")]
[DemangledName("_Accum __llvm_libc_20_1_2_::fixed_point::abs<_Accum>(_Accum)")]
internal static partial class Accum_fixed_point_abs_Accum_Accum
{
	public static int Invoke(int x)
	{
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(x == fixed_point_FXRep_Accum_MIN.Invoke(), expected: false))
		{
			return fixed_point_FXRep_Accum_MAX.Invoke();
		}
		return (x >= fixed_point_FXRep_Accum_ZERO.Invoke()) ? x : unchecked(-x);
	}
}
