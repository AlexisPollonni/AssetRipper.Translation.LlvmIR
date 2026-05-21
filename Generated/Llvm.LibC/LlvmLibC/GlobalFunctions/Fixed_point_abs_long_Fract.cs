using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_abs_long_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDRlEET_S2_")]
	[DemangledName("long _Fract __llvm_libc_20_1_2_::fixed_point::abs<long _Fract>(long _Fract)")]
	[return: NativeType("long")]
	public static int Invoke([MangledName("x")][NativeType("long _Fract")] int X)
	{
		if (Details_expects_bool_condition_bool.Invoke(X == FXRep_long_Fract_MIN.Invoke(), Expected: false))
		{
			return FXRep_long_Fract_MAX.Invoke();
		}
		return (X >= FXRep_long_Fract_ZERO.Invoke()) ? X : unchecked(-X);
	}
}
