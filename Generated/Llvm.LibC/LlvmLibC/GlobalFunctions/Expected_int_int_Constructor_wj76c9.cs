using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_int_int_Constructor_wj76c9
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIiiEC2ENS0_10unexpectedIiEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
	[CleanName("Expected_int_int_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("unexp.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::unexpected<int>")] int Unexp)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = new Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = Unexp
		};
		unchecked
		{
			Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt* field = &((Cpp_optional_int_OptionalStorage*)This)->field;
			*(int*)field = Unexpected_int_error.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
			((Cpp_optional_int_OptionalStorage*)This)->In_use = 0;
		}
	}
}
