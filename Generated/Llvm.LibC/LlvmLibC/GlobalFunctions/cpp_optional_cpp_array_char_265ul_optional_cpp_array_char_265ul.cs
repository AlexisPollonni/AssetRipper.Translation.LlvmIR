using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEC2EOS3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::optional(__llvm_libc_20_1_2_::cpp::array<char, 265ul>&&)")]
internal static partial class cpp_optional_cpp_array_char_265ul_optional_cpp_array_char_265ul
{
	public unsafe static void Invoke(cpp_optional_pjf72b* @this, cpp_array_55kc72* t)
	{
		cpp_optional_cpp_array_char_265ul_OptionalStorage_cpp_array_char_265ul_false_OptionalStorage_cpp_array_char_265ul_cpp_in_place_t_cpp_array_char_265ul.Invoke(&@this->storage, cpp_remove_reference_cpp_array_char_265ul_type_cpp_move_cpp_array_char_265ul_cpp_array_char_265ul.Invoke(t));
		@this->storage.in_use = 1;
	}
}
