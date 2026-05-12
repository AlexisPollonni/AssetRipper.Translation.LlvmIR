using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13callonce_impl17callonce_fastpathEPNS_5FutexE")]
[DemangledName("__llvm_libc_20_1_2_::callonce_impl::callonce_fastpath(__llvm_libc_20_1_2_::Futex*)")]
internal static partial class callonce_impl_callonce_fastpath_Futex
{
	public unsafe static bool Invoke(void* flag)
	{
		return cpp_Atomic_unsigned_int_load_cpp_MemoryOrder_cpp_MemoryScope.Invoke(flag, MemoryOrder.RELAXED, MemoryScope.DEVICE) == 51;
	}
}
