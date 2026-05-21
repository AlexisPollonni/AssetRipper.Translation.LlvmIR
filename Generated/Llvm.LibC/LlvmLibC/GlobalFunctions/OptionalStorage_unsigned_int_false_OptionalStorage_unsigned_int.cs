using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_unsigned_int_false_OptionalStorage_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjE15OptionalStorageIjLb0EEC2IJjEEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::OptionalStorage<unsigned int, false>::OptionalStorage<unsigned int>(__llvm_libc_20_1_2_::cpp::in_place_t, unsigned int&&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] void* @this, [NativeType("unsigned int&&")] void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt* field = &((cpp_optional_int_OptionalStorage*)@this)->field;
			*(int*)field = *(int*)cpp_forward_unsigned_int.Invoke(args);
			((cpp_optional_int_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
