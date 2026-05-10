using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14AuxvErrnoGuard12mark_failureEv")]
[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard::mark_failure()")]
internal static partial class AuxvErrnoGuard_mark_failure
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked((AuxvErrnoGuard*)@this)->failure = 1;
	}
}
