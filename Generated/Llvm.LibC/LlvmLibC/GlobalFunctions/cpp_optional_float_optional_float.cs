using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfEC2EOf")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::optional(float&&)")]
internal static partial class cpp_optional_float_optional_float
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_float_OptionalStorage_float_false_OptionalStorage_float_cpp_in_place_t_float.Invoke(&((cpp_optional_89h55j*)@this)->storage, cpp_remove_reference_float_type_cpp_move_float_float.Invoke(t));
			((cpp_optional_89h55j*)@this)->storage.in_use = 1;
		}
	}
}
