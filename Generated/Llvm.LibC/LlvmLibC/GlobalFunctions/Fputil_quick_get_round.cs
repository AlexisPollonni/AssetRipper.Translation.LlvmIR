using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_quick_get_round
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil15quick_get_roundEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::quick_get_round()")]
	public unsafe static int Invoke()
	{
		float num = 0f;
		float num2 = 0f;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Fputil_quick_get_round_x.Value;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 1.0000001f + num + (-1f - num);
		int result = ((num2 != 0f) ? ((num2 != 1.1920929E-07f) ? InstructionHelper.Select(2f + num == 2f, 0, 2048) : 3072) : 1024);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
