using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fixed_point_abs_short_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDAsEET_S2_")]
	[DemangledName("short _Accum __llvm_libc_20_1_2_::fixed_point::abs<short _Accum>(short _Accum)")]
	[return: NativeType("short")]
	public static short Invoke([MangledName("x")][NativeType("short _Accum")] short X)
	{
		short num = X;
		if (Details_expects_bool_condition_bool.Invoke(num == FXRep_short_Accum_MIN.Invoke(), Expected: false))
		{
			return FXRep_short_Accum_MAX.Invoke();
		}
		return unchecked((short)((num >= FXRep_short_Accum_ZERO.Invoke()) ? num : (-num)));
	}
}
