using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIlEC2EOl")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long>::optional(long&&)")]
internal static partial class cpp_optional_long_optional_long
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_long_OptionalStorage_long_false_OptionalStorage_long_cpp_in_place_t_long.Invoke(&((cpp_optional_d6hvji*)@this)->storage, cpp_remove_reference_long_type_cpp_move_long_long.Invoke(t));
			((cpp_optional_d6hvji*)@this)->storage.in_use = 1;
		}
	}
}
