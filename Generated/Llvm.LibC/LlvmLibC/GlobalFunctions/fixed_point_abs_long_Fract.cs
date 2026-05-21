using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_abs_long_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDRlEET_S2_")]
	[DemangledName("long _Fract __llvm_libc_20_1_2_::fixed_point::abs<long _Fract>(long _Fract)")]
	[return: NativeType("long")]
	public static int Invoke([NativeType("long _Fract")] int x)
	{
		if (details_expects_bool_condition_bool.Invoke(x == FXRep_long_Fract_MIN.Invoke(), expected: false))
		{
			return FXRep_long_Fract_MAX.Invoke();
		}
		return (x >= FXRep_long_Fract_ZERO.Invoke()) ? x : unchecked(-x);
	}
}
