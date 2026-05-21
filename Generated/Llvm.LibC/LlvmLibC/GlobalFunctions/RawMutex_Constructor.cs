using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class RawMutex_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8RawMutexC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::RawMutex::RawMutex()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		Futex_Constructor.Invoke(&unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)This)->FPRepSem, 0);
	}
}
