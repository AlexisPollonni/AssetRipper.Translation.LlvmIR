using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvErrnoGuard_mark_failure
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14AuxvErrnoGuard12mark_failureEv")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard::mark_failure()")]
	public unsafe static void Invoke(AuxvErrnoGuard* @this)
	{
		@this->failure = 1;
	}
}
