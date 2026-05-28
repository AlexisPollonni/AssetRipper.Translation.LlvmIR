using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_int_Constructor_5uypfr
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE8TypedIntIiEC2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::TypedInt<int>::TypedInt(int)")]
	[CleanName("TypedInt_int_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("int")] int Value)
	{
		unchecked((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 = Value;
	}
}
