using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEEC2EOS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&&)")]
internal static partial class cpp_optional_internal_ExpandedFloat_long_double_optional_internal_ExpandedFloat_long_double
{
	public unsafe static void Invoke(cpp_optional_q5jaj8* @this, internal_ExpandedFloat_9jummq* t)
	{
		cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage_internal_ExpandedFloat_long_double_false_OptionalStorage_internal_ExpandedFloat_long_double_cpp_in_place_t_internal_ExpandedFloat_long_double.Invoke(&@this->storage, cpp_remove_reference_internal_ExpandedFloat_long_double_type_cpp_move_internal_ExpandedFloat_long_double_internal_ExpandedFloat_long_double.Invoke(t));
		@this->storage.in_use = 1;
	}
}
