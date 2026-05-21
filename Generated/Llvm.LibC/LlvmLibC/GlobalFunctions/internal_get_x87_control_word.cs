using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_get_x87_control_word
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal20get_x87_control_wordEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::get_x87_control_word()")]
	public unsafe static short Invoke()
	{
		short num = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = -21846;
		IntrinsicFunctions.AsmFnstcw(&num);
		short result = num;
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
