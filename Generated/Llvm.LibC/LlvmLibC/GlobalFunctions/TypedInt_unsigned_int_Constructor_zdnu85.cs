using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_int_Constructor_zdnu85
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE8TypedIntIjEC2Ej")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::TypedInt<unsigned int>::TypedInt(unsigned int)")]
	[CleanName("TypedInt_unsigned_int_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("unsigned int")] int Value)
	{
		unchecked((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 = Value;
	}
}
