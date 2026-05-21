using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_int_scope
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjE5scopeENS0_11MemoryScopeE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::scope(__llvm_libc_20_1_2_::cpp::MemoryScope)")]
	public static int Invoke([NativeType("__llvm_libc_20_1_2_::cpp::MemoryScope")] MemoryScope mem_scope)
	{
		return unchecked((int)mem_scope);
	}
}
