using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjEC2Ej")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::Atomic(unsigned int)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int v)
	{
		unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = v;
	}
}
