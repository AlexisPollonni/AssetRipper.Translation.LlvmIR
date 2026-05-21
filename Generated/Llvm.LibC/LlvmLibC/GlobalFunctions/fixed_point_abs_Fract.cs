using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_abs_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDRiEET_S2_")]
	[DemangledName("_Fract __llvm_libc_20_1_2_::fixed_point::abs<_Fract>(_Fract)")]
	[return: NativeType("_Fract")]
	public static short Invoke([NativeType("_Fract")] short x)
	{
		short num = x;
		if (details_expects_bool_condition_bool.Invoke(num == FXRep_Fract_MIN.Invoke(), expected: false))
		{
			return FXRep_Fract_MAX.Invoke();
		}
		return unchecked((short)((num >= FXRep_Fract_ZERO.Invoke()) ? num : (-num)));
	}
}
