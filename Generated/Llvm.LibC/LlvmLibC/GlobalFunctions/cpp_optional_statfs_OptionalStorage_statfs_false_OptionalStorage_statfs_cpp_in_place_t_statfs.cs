using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsE15OptionalStorageIS2_Lb0EEC2IJS2_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::OptionalStorage<statfs, false>::OptionalStorage<statfs>(__llvm_libc_20_1_2_::cpp::in_place_t, statfs&&)")]
internal static partial class cpp_optional_statfs_OptionalStorage_statfs_false_OptionalStorage_statfs_cpp_in_place_t_statfs
{
	public unsafe static void Invoke(cpp_optional_statfs_OptionalStorage* @this, void* args)
	{
		llvm_memcpy_p0_p0_i64.Invoke(&@this->field, statfs_cpp_forward_statfs_cpp_remove_reference_statfs_type.Invoke(unchecked((statfs*)args)), 120L, isVolatile: false);
		@this->in_use = 0;
	}
}
