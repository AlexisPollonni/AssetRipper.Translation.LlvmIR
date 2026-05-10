using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiE15OptionalStorageIiLb0EEC2IJiEEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::OptionalStorage<int, false>::OptionalStorage<int>(__llvm_libc_20_1_2_::cpp::in_place_t, int&&)")]
internal static partial class cpp_optional_int_OptionalStorage_int_false_OptionalStorage_int_cpp_in_place_t_int
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt* field = &((cpp_optional_int_OptionalStorage*)@this)->field;
			*(int*)field = *(int*)int_cpp_forward_int_cpp_remove_reference_int_type.Invoke(args);
			((cpp_optional_int_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
