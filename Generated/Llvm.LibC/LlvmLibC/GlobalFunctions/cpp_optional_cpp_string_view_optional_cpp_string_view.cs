using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEC2EOS2_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::optional(__llvm_libc_20_1_2_::cpp::string_view&&)")]
internal static partial class cpp_optional_cpp_string_view_optional_cpp_string_view
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_cpp_string_view_OptionalStorage_cpp_string_view_false_OptionalStorage_cpp_string_view_cpp_in_place_t_cpp_string_view.Invoke(&((cpp_optional_q73pcj*)@this)->storage, cpp_remove_reference_cpp_string_view_type_cpp_move_cpp_string_view_cpp_string_view.Invoke(t));
			((cpp_optional_q73pcj*)@this)->storage.in_use = 1;
		}
	}
}
