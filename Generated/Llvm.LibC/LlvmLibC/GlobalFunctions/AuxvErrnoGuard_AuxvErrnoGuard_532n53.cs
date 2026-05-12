using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14AuxvErrnoGuardC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard::AuxvErrnoGuard()")]
[CleanName("AuxvErrnoGuard_AuxvErrnoGuard")]
internal static partial class AuxvErrnoGuard_AuxvErrnoGuard_532n53
{
	public unsafe static void Invoke(AuxvErrnoGuard* @this)
	{
		@this->saved = Errno_operator_int_exthys.Invoke(libc_errno.Pointer);
		@this->failure = 0;
	}
}
