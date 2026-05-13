using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil18fenv_is_round_downEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::fenv_is_round_down()")]
internal static partial class fputil_fenv_is_round_down
{
	public unsafe static bool Invoke()
	{
		float num = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 2.9802322E-08f;
		bool result = NumericHelper.IsUnorderedOrNotEquals(-1f - num, -1f);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
