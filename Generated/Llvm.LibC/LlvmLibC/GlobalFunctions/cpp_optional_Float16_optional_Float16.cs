using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_EC2EODF16_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::optional(_Float16&&)")]
internal static partial class cpp_optional_Float16_optional_Float16
{
	public unsafe static void Invoke(cpp_optional_aq7wey* @this, void* t)
	{
		cpp_optional_Float16_OptionalStorage_Float16_false_OptionalStorage_Float16_cpp_in_place_t_Float16.Invoke(&@this->storage, cpp_remove_reference_Float16_type_cpp_move_Float16_Float16.Invoke(t));
		@this->storage.in_use = 1;
	}
}
