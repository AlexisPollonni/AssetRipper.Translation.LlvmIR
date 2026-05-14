using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiEC2ENS0_10unexpectedIiEE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
internal static partial class cpp_expected_LinuxFile_int_expected_cpp_unexpected_int
{
	public unsafe static void Invoke(void* @this, [MangledName("unexp.coerce")] int unexp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = unexp
		};
		unchecked
		{
			anon_5uk363* field = &((cpp_optional_char_OptionalStorage*)@this)->field;
			*(int*)field = cpp_unexpected_int_error.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
