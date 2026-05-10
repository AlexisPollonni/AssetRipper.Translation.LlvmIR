using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeEC2EOe")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::optional(long double&&)")]
internal static partial class cpp_optional_long_double_optional_long_double
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_long_double_OptionalStorage_long_double_false_OptionalStorage_long_double_cpp_in_place_t_long_double.Invoke(&((cpp_optional_59q3zq*)@this)->storage, cpp_remove_reference_long_double_type_cpp_move_long_double_long_double.Invoke(t));
			((cpp_optional_59q3zq*)@this)->storage.field_1 = 1;
		}
	}
}
