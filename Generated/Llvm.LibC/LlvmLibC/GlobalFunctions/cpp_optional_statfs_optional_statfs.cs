using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalI6statfsEC2EOS2_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<statfs>::optional(statfs&&)")]
internal static partial class cpp_optional_statfs_optional_statfs
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_statfs_OptionalStorage_statfs_false_OptionalStorage_statfs_cpp_in_place_t_statfs.Invoke(&((cpp_optional_hij69m*)@this)->storage, cpp_remove_reference_statfs_type_cpp_move_statfs_statfs.Invoke(t));
			((cpp_optional_hij69m*)@this)->storage.in_use = 1;
		}
	}
}
