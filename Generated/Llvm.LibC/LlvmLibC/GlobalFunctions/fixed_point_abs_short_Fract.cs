using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_abs_short_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDRsEET_S2_")]
	[DemangledName("short _Fract __llvm_libc_20_1_2_::fixed_point::abs<short _Fract>(short _Fract)")]
	[return: NativeType("short")]
	public static sbyte Invoke([NativeType("short _Fract")] sbyte x)
	{
		sbyte b = x;
		if (details_expects_bool_condition_bool.Invoke(b == FXRep_short_Fract_MIN.Invoke(), expected: false))
		{
			return FXRep_short_Fract_MAX.Invoke();
		}
		return unchecked((sbyte)((b >= FXRep_short_Fract_ZERO.Invoke()) ? b : (-b)));
	}
}
