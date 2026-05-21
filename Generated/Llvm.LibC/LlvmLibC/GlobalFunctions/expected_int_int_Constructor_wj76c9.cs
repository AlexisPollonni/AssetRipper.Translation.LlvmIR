using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expected_int_int_Constructor_wj76c9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIiiEC2ENS0_10unexpectedIiEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
	[CleanName("expected_int_int_Constructor")]
	public unsafe static void Invoke(void* @this, [MangledName("unexp.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::unexpected<int>")] int unexp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = unexp
		};
		unchecked
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt* field = &((cpp_optional_int_OptionalStorage*)@this)->field;
			*(int*)field = unexpected_int_error.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
			((cpp_optional_int_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
