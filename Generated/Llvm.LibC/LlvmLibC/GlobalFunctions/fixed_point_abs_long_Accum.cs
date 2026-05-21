using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_abs_long_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDAlEET_S2_")]
	[DemangledName("long _Accum __llvm_libc_20_1_2_::fixed_point::abs<long _Accum>(long _Accum)")]
	[return: NativeType("long")]
	public static long Invoke([NativeType("long _Accum")] long x)
	{
		if (details_expects_bool_condition_bool.Invoke(x == FXRep_long_Accum_MIN.Invoke(), expected: false))
		{
			return FXRep_long_Accum_MAX.Invoke();
		}
		return (x >= FXRep_long_Accum_ZERO.Invoke()) ? x : unchecked(-x);
	}
}
