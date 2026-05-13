using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE9addressofERm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::addressof(unsigned long&)")]
internal static partial class cpp_Atomic_unsigned_long_addressof_unsigned_long
{
	public unsafe static void* Invoke(void* @ref)
	{
		return @ref;
	}
}
