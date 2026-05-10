using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8RawMutexC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::RawMutex::RawMutex()")]
internal static partial class RawMutex_RawMutex
{
	public unsafe static void Invoke(void* @this)
	{
		Futex_Futex_unsigned_int.Invoke(&unchecked((fputil_internal_FPRepImpl_vhj4tm*)@this)->FPRepSem, 0);
	}
}
