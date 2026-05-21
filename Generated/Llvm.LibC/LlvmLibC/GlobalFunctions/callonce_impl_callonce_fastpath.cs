using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;

namespace LlvmLibC.GlobalFunctions;

internal static partial class callonce_impl_callonce_fastpath
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13callonce_impl17callonce_fastpathEPNS_5FutexE")]
	[DemangledName("__llvm_libc_20_1_2_::callonce_impl::callonce_fastpath(__llvm_libc_20_1_2_::Futex*)")]
	public unsafe static bool Invoke([NativeType("__llvm_libc_20_1_2_::Futex*")] void* flag)
	{
		return Atomic_unsigned_int_load.Invoke(flag, MemoryOrder.RELAXED, MemoryScope.DEVICE) == 51;
	}
}
