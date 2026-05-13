using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiEC2EOi")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::optional(int&&)")]
internal static partial class cpp_optional_int_optional_int
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_int_OptionalStorage_int_false_OptionalStorage_int_cpp_in_place_t_int.Invoke(&((cpp_optional_39hkks*)@this)->storage, cpp_remove_reference_int_type_cpp_move_int_int.Invoke(t));
			((cpp_optional_39hkks*)@this)->storage.in_use = 1;
		}
	}
}
