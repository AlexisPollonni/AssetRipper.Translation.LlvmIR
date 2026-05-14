using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvEC2EOS2_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::optional(void*&&)")]
internal static partial class cpp_optional_void_optional_void
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_void_OptionalStorage_void_false_OptionalStorage_void_cpp_in_place_t_void.Invoke(&((cpp_optional_77yu8f*)@this)->storage, cpp_remove_reference_void_type_cpp_move_void_void.Invoke(t));
			((cpp_optional_77yu8f*)@this)->storage.in_use = 1;
		}
	}
}
