using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9get_mxcsrEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::get_mxcsr()")]
internal static partial class fputil_internal_get_mxcsr
{
	public unsafe static int Invoke()
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = -1431655766;
		IntrinsicFunctions.AsmStmxcsr(&num);
		int result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
