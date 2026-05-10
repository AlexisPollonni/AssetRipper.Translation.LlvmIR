using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIlE15OptionalStorageIlLb0EEC2IJlEEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long>::OptionalStorage<long, false>::OptionalStorage<long>(__llvm_libc_20_1_2_::cpp::in_place_t, long&&)")]
internal static partial class cpp_optional_long_OptionalStorage_long_false_OptionalStorage_long_cpp_in_place_t_long
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_v3nexn* field = &((cpp_expected*)@this)->field;
			*(long*)field = *(long*)long_cpp_forward_long_cpp_remove_reference_long_type.Invoke(args);
			((cpp_expected*)@this)->in_use = 0;
		}
	}
}
