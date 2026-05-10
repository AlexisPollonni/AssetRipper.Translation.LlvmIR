using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp10unexpectedIiEC2Ei")]
[DemangledName("__llvm_libc_20_1_2_::cpp::unexpected<int>::unexpected(int)")]
internal static partial class cpp_unexpected_int_unexpected_int
{
	public unsafe static void Invoke(void* @this, int value)
	{
		unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = value;
	}
}
