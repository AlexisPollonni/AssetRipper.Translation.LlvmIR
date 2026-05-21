using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvErrnoGuard_Destructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14AuxvErrnoGuardD2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard::~AuxvErrnoGuard()")]
	public unsafe static void Invoke(AuxvErrnoGuard* @this)
	{
		Errno_Assignment.Invoke(a: ((@this->failure & 1) != 1) ? @this->saved : 2, @this: libc_errno.Pointer);
	}
}
