using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_set_errno_if_required
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil21set_errno_if_requiredEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::set_errno_if_required(int)")]
	public unsafe static void Invoke([MangledName("err")][NativeType("int")] int Err)
	{
		Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, Err);
	}
}
