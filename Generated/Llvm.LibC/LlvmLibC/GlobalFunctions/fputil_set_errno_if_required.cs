using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_set_errno_if_required
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil21set_errno_if_requiredEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::set_errno_if_required(int)")]
	public unsafe static void Invoke([NativeType("int")] int err)
	{
		Errno_Assignment.Invoke(libc_errno.Pointer, err);
	}
}
