using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjEC2Ej")]
[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::Atomic(unsigned int)")]
internal static partial class cpp_Atomic_unsigned_int_Atomic_unsigned_int
{
	public unsafe static void Invoke(void* @this, int v)
	{
		unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = v;
	}
}
