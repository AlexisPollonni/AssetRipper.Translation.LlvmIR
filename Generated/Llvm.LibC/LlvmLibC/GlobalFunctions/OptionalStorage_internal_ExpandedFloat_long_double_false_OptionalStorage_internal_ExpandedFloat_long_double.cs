using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_internal_ExpandedFloat_long_double_false_OptionalStorage_internal_ExpandedFloat_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEE15OptionalStorageIS4_Lb0EEC2IJS4_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, false>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&&)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage* @this, [NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&&")] void* args)
	{
		llvm_memcpy_p0_p0_i64.Invoke(&@this->field, cpp_forward_internal_ExpandedFloat_long_double.Invoke(unchecked((internal_ExpandedFloat_9jummq*)args)), 32L, isVolatile: false);
		@this->in_use = 0;
	}
}
