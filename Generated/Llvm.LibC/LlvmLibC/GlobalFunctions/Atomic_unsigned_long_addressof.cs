using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_long_addressof
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE9addressofERm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::addressof(unsigned long&)")]
	public unsafe static void* Invoke([MangledName("ref")][NativeType("unsigned long&")] void* Ref)
	{
		return Ref;
	}
}
