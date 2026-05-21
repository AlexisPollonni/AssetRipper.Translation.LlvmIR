using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_int_addressof
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjE9addressofERj")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::addressof(unsigned int&)")]
	public unsafe static void* Invoke([NativeType("unsigned int&")] void* @ref)
	{
		return @ref;
	}
}
