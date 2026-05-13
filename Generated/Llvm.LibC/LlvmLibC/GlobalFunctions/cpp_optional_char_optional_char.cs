using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPcEC2EOS2_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::optional(char*&&)")]
internal static partial class cpp_optional_char_optional_char
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_char_OptionalStorage_char_false_OptionalStorage_char_cpp_in_place_t_char.Invoke(&((cpp_optional_e5s7qx*)@this)->storage, cpp_remove_reference_char_type_cpp_move_char_char.Invoke(t));
			((cpp_optional_e5s7qx*)@this)->storage.in_use = 1;
		}
	}
}
