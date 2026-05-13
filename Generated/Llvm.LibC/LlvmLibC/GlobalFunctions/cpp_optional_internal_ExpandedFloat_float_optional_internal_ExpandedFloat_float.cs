using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEEC2EOS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&)")]
internal static partial class cpp_optional_internal_ExpandedFloat_float_optional_internal_ExpandedFloat_float
{
	public unsafe static void Invoke(cpp_optional_6hseum* @this, internal_ExpandedFloat_i7t5up* t)
	{
		cpp_optional_internal_ExpandedFloat_float_OptionalStorage_internal_ExpandedFloat_float_false_OptionalStorage_internal_ExpandedFloat_float_cpp_in_place_t_internal_ExpandedFloat_float.Invoke(&@this->storage, cpp_remove_reference_internal_ExpandedFloat_float_type_cpp_move_internal_ExpandedFloat_float_internal_ExpandedFloat_float.Invoke(t));
		@this->storage.in_use = 1;
	}
}
