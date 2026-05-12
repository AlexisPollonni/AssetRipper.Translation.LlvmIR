using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE5scopeENS0_11MemoryScopeE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::scope(__llvm_libc_20_1_2_::cpp::MemoryScope)")]
internal static partial class cpp_Atomic_unsigned_long_scope_cpp_MemoryScope
{
	public static int Invoke(MemoryScope mem_scope)
	{
		return unchecked((int)mem_scope);
	}
}
