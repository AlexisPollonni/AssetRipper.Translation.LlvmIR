using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEC2ENS0_9nullopt_tE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
internal static partial class cpp_optional_cpp_array_char_265ul_optional_cpp_nullopt_t
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_optional_cpp_array_char_265ul_OptionalStorage_cpp_array_char_265ul_false_OptionalStorage.Invoke(&unchecked((cpp_optional_pjf72b*)@this)->storage);
	}
}
