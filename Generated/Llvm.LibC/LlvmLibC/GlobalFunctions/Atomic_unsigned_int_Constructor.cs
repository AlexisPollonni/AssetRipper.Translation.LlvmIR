using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicIjEC2Ej")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned int>::Atomic(unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("v")][NativeType("unsigned int")] int V)
	{
		unchecked((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 = V;
	}
}
