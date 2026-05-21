using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvErrnoGuard_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14AuxvErrnoGuardC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard::AuxvErrnoGuard()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_AuxvErrnoGuard* This)
	{
		This->Saved = Errno_ToInt32.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer);
		This->Failure = 0;
	}
}
