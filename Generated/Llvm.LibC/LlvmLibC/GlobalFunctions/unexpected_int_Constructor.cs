using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class unexpected_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp10unexpectedIiEC2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::unexpected<int>::unexpected(int)")]
	public unsafe static void Invoke(void* @this, [NativeType("int")] int value)
	{
		unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = value;
	}
}
