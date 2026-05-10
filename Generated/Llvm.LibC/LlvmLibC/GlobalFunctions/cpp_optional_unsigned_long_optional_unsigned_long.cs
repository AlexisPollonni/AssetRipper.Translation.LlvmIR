using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImEC2EOm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::optional(unsigned long&&)")]
internal static partial class cpp_optional_unsigned_long_optional_unsigned_long
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_unsigned_long_OptionalStorage_unsigned_long_false_OptionalStorage_unsigned_long_cpp_in_place_t_unsigned_long.Invoke(&((cpp_optional_d6hvji*)@this)->storage, cpp_remove_reference_unsigned_long_type_cpp_move_unsigned_long_unsigned_long.Invoke(t));
			((cpp_optional_d6hvji*)@this)->storage.in_use = 1;
		}
	}
}
