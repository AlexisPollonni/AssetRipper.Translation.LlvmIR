using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expected_File_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_4FileEiEC2ENS0_10unexpectedIiEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::File*, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
	public unsafe static void Invoke(void* @this, [MangledName("unexp.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::unexpected<int>")] int unexp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = unexp
		};
		unchecked
		{
			anon_5uk363* field = &((cpp_optional_char_OptionalStorage*)@this)->field;
			*(int*)field = unexpected_int_error.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 0;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_4FileEiEC2ES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::File*, int>::expected(__llvm_libc_20_1_2_::File*)")]
	public unsafe static void Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::File*")] File_sjnxn4* exp)
	{
		unchecked
		{
			*(File_sjnxn4**)(&((cpp_optional_char_OptionalStorage*)@this)->field) = exp;
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 1;
		}
	}
}
