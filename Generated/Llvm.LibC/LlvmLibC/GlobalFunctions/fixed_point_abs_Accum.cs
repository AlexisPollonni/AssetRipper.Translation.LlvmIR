using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fixed_point_abs_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point3absIDAiEET_S2_")]
	[DemangledName("_Accum __llvm_libc_20_1_2_::fixed_point::abs<_Accum>(_Accum)")]
	[return: NativeType("_Accum")]
	public static int Invoke([NativeType("_Accum")] int x)
	{
		if (details_expects_bool_condition_bool.Invoke(x == FXRep_Accum_MIN.Invoke(), expected: false))
		{
			return FXRep_Accum_MAX.Invoke();
		}
		return (x >= FXRep_Accum_ZERO.Invoke()) ? x : unchecked(-x);
	}
}
