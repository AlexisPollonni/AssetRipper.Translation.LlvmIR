using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil21set_errno_if_requiredEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::set_errno_if_required(int)")]
internal static partial class fputil_set_errno_if_required_int
{
	public unsafe static void Invoke(int err)
	{
		Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, err);
	}
}
