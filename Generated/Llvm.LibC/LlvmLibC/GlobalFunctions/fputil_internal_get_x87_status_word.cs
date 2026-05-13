using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal19get_x87_status_wordEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::get_x87_status_word()")]
internal static partial class fputil_internal_get_x87_status_word
{
	public unsafe static short Invoke()
	{
		short num = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = -21846;
		IntrinsicFunctions.AsmFnstsw(&num);
		short result = num;
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
