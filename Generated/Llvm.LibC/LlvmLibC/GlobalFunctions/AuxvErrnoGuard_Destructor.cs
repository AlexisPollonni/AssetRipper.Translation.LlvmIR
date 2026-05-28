using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvErrnoGuard_Destructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14AuxvErrnoGuardD2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard::~AuxvErrnoGuard()")]
	public unsafe static void Invoke([MangledName("this")] AuxvErrnoGuard* This)
	{
		Errno_Assignment.Invoke(A: ((This->Failure & 1) != 1) ? This->Saved : 2, This: Libc_errno.Pointer);
	}
}
