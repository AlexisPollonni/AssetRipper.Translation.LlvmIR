using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEE15OptionalStorageIS4_Lb0EEC2IJS4_EEENS0_10in_place_tEDpOT_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, false>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::internal::ExpandedFloat<double>&&)")]
internal static partial class cpp_optional_internal_ExpandedFloat_double_OptionalStorage_internal_ExpandedFloat_double_false_OptionalStorage_internal_ExpandedFloat_double_cpp_in_place_t_internal_ExpandedFloat_double
{
	public unsafe static void Invoke(void* @this, void* args)
	{
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((cpp_optional_internal_ExpandedFloat_double_OptionalStorage*)@this)->field, internal_ExpandedFloat_double_cpp_forward_internal_ExpandedFloat_double_cpp_remove_reference_internal_ExpandedFloat_double_type.Invoke(args), 16L, isVolatile: false);
			((cpp_optional_internal_ExpandedFloat_double_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
