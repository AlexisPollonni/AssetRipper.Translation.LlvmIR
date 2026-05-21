using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fenv_is_round_to_nearest
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil24fenv_is_round_to_nearestEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::fenv_is_round_to_nearest()")]
	public unsafe static bool Invoke()
	{
		float num = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = fputil_fenv_is_round_to_nearest_x.Value;
		bool result = 1.5f + num == 1.5f - num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
