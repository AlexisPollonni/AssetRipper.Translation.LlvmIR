using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjEC2EOj")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::optional(unsigned int&&)")]
internal static partial class cpp_optional_unsigned_int_optional_unsigned_int
{
	public unsafe static void Invoke(void* @this, void* t)
	{
		unchecked
		{
			cpp_optional_unsigned_int_OptionalStorage_unsigned_int_false_OptionalStorage_unsigned_int_cpp_in_place_t_unsigned_int.Invoke(&((cpp_optional_g66fk4*)@this)->storage, cpp_remove_reference_unsigned_int_type_cpp_move_unsigned_int_unsigned_int.Invoke(t));
			((cpp_optional_g66fk4*)@this)->storage.in_use = 1;
		}
	}
}
