using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxE15OptionalStorageIxLb0EEC2IJxEEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::OptionalStorage<long long, false>::OptionalStorage<long long>(__llvm_libc_20_1_2_::cpp::in_place_t, long long&&)")]
internal static partial class cpp_optional_long_long_OptionalStorage_long_long_false_OptionalStorage_long_long_cpp_in_place_t_long_long
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			fputil_internal_FPStorage_v3nexn* field = &((cpp_expected*)@this)->field;
			*(long*)field = *(long*)long_long_cpp_forward_long_long_cpp_remove_reference_long_long_type.Invoke(args);
			((cpp_expected*)@this)->in_use = 0;
		}
	}
}
