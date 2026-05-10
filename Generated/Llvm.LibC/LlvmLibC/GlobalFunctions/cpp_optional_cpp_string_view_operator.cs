using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEdeEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::operator*() &")]
internal static partial class cpp_optional_cpp_string_view_operator
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_q73pcj*)@this)->storage.field;
	}
}
