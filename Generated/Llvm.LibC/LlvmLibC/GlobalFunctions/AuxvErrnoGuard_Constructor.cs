using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvErrnoGuard_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14AuxvErrnoGuardC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard::AuxvErrnoGuard()")]
	public unsafe static void Invoke(AuxvErrnoGuard* @this)
	{
		@this->saved = Errno_ToInt32.Invoke(libc_errno.Pointer);
		@this->failure = 0;
	}
}
