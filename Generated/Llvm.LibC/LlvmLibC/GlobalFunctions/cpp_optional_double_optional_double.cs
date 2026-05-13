using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdEC2EOd")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::optional(double&&)")]
internal static partial class cpp_optional_double_optional_double
{
	public unsafe static void Invoke(cpp_optional_s4iqgj* @this, void* t)
	{
		cpp_optional_double_OptionalStorage_double_false_OptionalStorage_double_cpp_in_place_t_double.Invoke(&@this->storage, cpp_remove_reference_double_type_cpp_move_double_double.Invoke(t));
		@this->storage.in_use = 1;
	}
}
