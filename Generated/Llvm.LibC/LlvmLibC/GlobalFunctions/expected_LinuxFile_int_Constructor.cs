using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expected_LinuxFile_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiEC2ENS0_10unexpectedIiEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
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

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiEC2ES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::expected(__llvm_libc_20_1_2_::LinuxFile*)")]
	public unsafe static void Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::LinuxFile*")] LinuxFile* exp)
	{
		unchecked
		{
			*(LinuxFile**)(&((cpp_optional_char_OptionalStorage*)@this)->field) = exp;
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 1;
		}
	}
}
