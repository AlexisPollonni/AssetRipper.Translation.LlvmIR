using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_LinuxFile_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiEC2ENS0_10unexpectedIiEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::expected(__llvm_libc_20_1_2_::cpp::unexpected<int>)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("unexp.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::unexpected<int>")] int Unexp)
	{
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = new Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt
		{
			field_0 = Unexp
		};
		unchecked
		{
			Anon_5uk363* field = &((Cpp_optional_char_OptionalStorage*)This)->field;
			*(int*)field = Unexpected_int_error.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
			((Cpp_optional_char_OptionalStorage*)This)->In_use = 0;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiEC2ES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::expected(__llvm_libc_20_1_2_::LinuxFile*)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("exp")][NativeType("__llvm_libc_20_1_2_::LinuxFile*")] LinuxFile* Exp)
	{
		unchecked
		{
			*(LinuxFile**)(&((Cpp_optional_char_OptionalStorage*)This)->field) = Exp;
			((Cpp_optional_char_OptionalStorage*)This)->In_use = 1;
		}
	}
}
