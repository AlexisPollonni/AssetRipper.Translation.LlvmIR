using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliEC2ENS0_10unexpectedIiEE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
internal static partial class cpp_expected_long_int_expected_cpp_unexpected_int
{
	public unsafe static void Invoke(void* @this, [MangledName("unexp.coerce")] int unexp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = unexp
		};
		unchecked
		{
			fputil_internal_FPStorage_v3nexn* field = &((cpp_expected*)@this)->field;
			*(int*)field = cpp_unexpected_int_error.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
			((cpp_expected*)@this)->in_use = 0;
		}
	}
}
