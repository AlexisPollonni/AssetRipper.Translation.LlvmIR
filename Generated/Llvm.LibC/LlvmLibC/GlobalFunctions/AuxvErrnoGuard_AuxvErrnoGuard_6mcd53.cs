using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14AuxvErrnoGuardD2Ev")]
[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard::~AuxvErrnoGuard()")]
[CleanName("AuxvErrnoGuard_AuxvErrnoGuard")]
internal static partial class AuxvErrnoGuard_AuxvErrnoGuard_6mcd53
{
	public unsafe static void Invoke(AuxvErrnoGuard* @this)
	{
		Errno_operator_int_dntwiy.Invoke(a: ((@this->failure & 1) != 1) ? @this->saved : 2, @this: libc_errno.Pointer);
	}
}
