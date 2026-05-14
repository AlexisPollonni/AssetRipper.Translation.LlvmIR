using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::optional()")]
internal static partial class cpp_optional_cpp_string_view_optional
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_optional_cpp_string_view_OptionalStorage_cpp_string_view_false_OptionalStorage.Invoke(&unchecked((cpp_optional_bnt67x*)@this)->storage);
	}
}
