using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_long_order
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE5orderENS0_11MemoryOrderE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::order(__llvm_libc_20_1_2_::cpp::MemoryOrder)")]
	public static int Invoke([MangledName("mem_ord")][NativeType("__llvm_libc_20_1_2_::cpp::MemoryOrder")] MemoryOrder Mem_ord)
	{
		return unchecked((int)Mem_ord);
	}
}
