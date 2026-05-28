using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Unexpected_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp10unexpectedIiEC2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::unexpected<int>::unexpected(int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("int")] int Value)
	{
		unchecked((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 = Value;
	}
}
