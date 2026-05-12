using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEEC2EOS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&&)")]
internal static partial class cpp_optional_internal_ExpandedFloat_double_optional_internal_ExpandedFloat_double
{
	public unsafe static void Invoke(cpp_optional_vqqfu4* @this, internal_ExpandedFloat_k68bhv* t)
	{
		cpp_optional_internal_ExpandedFloat_double_OptionalStorage_internal_ExpandedFloat_double_false_OptionalStorage_internal_ExpandedFloat_double_cpp_in_place_t_internal_ExpandedFloat_double.Invoke(&@this->storage, cpp_remove_reference_internal_ExpandedFloat_double_type_cpp_move_internal_ExpandedFloat_double_internal_ExpandedFloat_double.Invoke(t));
		@this->storage.in_use = 1;
	}
}
