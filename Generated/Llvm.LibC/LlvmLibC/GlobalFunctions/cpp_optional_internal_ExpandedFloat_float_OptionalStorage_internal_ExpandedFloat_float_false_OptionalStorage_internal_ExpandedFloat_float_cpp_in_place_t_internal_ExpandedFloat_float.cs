using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEE15OptionalStorageIS4_Lb0EEC2IJS4_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, false>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&)")]
internal static partial class cpp_optional_internal_ExpandedFloat_float_OptionalStorage_internal_ExpandedFloat_float_false_OptionalStorage_internal_ExpandedFloat_float_cpp_in_place_t_internal_ExpandedFloat_float
{
	public unsafe static void Invoke(cpp_optional_internal_ExpandedFloat_float_OptionalStorage* @this, void* args)
	{
		llvm_memcpy_p0_p0_i64.Invoke(&@this->field, internal_ExpandedFloat_float_cpp_forward_internal_ExpandedFloat_float_cpp_remove_reference_internal_ExpandedFloat_float_type.Invoke(unchecked((internal_ExpandedFloat_i7t5up*)args)), 8L, isVolatile: false);
		@this->in_use = 0;
	}
}
