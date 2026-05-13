using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjE15OptionalStorageIjLb0EEC2IJjEEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::OptionalStorage<unsigned int, false>::OptionalStorage<unsigned int>(__llvm_libc_20_1_2_::cpp::in_place_t, unsigned int&&)")]
internal static partial class cpp_optional_unsigned_int_OptionalStorage_unsigned_int_false_OptionalStorage_unsigned_int_cpp_in_place_t_unsigned_int
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt* field = &((cpp_optional_int_OptionalStorage*)@this)->field;
			*(int*)field = *(int*)unsigned_int_cpp_forward_unsigned_int_cpp_remove_reference_unsigned_int_type.Invoke(args);
			((cpp_optional_int_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
