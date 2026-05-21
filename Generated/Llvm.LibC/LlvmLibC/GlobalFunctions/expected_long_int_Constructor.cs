using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expected_long_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliEC2ENS0_10unexpectedIiEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
	public unsafe static void Invoke(void* @this, [MangledName("unexp.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::unexpected<int>")] int unexp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = unexp
		};
		unchecked
		{
			fputil_internal_FPStorage_v3nexn* field = &((cpp_expected*)@this)->field;
			*(int*)field = unexpected_int_error.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
			((cpp_expected*)@this)->in_use = 0;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliEC2El")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::expected(long)")]
	public unsafe static void Invoke(void* @this, [NativeType("long")] long exp)
	{
		unchecked
		{
			*(long*)(&((cpp_expected*)@this)->field) = exp;
			((cpp_expected*)@this)->in_use = 1;
		}
	}
}
