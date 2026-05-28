using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_unsigned_int_false_OptionalStorage_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjE15OptionalStorageIjLb0EEC2IJjEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::OptionalStorage<unsigned int, false>::OptionalStorage<unsigned int>(__llvm_libc_20_1_2_::cpp::in_place_t, unsigned int&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* This, [MangledName("args")][NativeType("unsigned int&&")] void* Args)
	{
		unchecked
		{
			Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt* field = &((Cpp_optional_int_OptionalStorage*)This)->field;
			*(int*)field = *(int*)Cpp_forward_unsigned_int.Invoke(Args);
			((Cpp_optional_int_OptionalStorage*)This)->In_use = 0;
		}
	}
}
