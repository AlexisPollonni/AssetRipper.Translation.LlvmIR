using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_abs_long_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDAlEET_S2_")]
	[DemangledName("long _Accum __llvm_libc_20_1_2_::fixed_point::abs<long _Accum>(long _Accum)")]
	[return: NativeType("long")]
	public static long Invoke([MangledName("x")][NativeType("long _Accum")] long X)
	{
		if (Details_expects_bool_condition_bool.Invoke(X == FXRep_long_Accum_MIN.Invoke(), Expected: false))
		{
			return FXRep_long_Accum_MAX.Invoke();
		}
		return (X >= FXRep_long_Accum_ZERO.Invoke()) ? X : unchecked(-X);
	}
}
