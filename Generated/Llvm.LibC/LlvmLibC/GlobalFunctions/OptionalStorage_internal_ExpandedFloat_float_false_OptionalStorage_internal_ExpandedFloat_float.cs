using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_internal_ExpandedFloat_float_false_OptionalStorage_internal_ExpandedFloat_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEE15OptionalStorageIS4_Lb0EEC2IJS4_EEENS0_10in_place_tEDpOT_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, false>::OptionalStorage<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>(__llvm_libc_20_1_2_::cpp::in_place_t, __llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::in_place_t")] Cpp_optional_internal_ExpandedFloat_float_OptionalStorage* This, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&")] void* Args)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(&This->field, Cpp_forward_internal_ExpandedFloat_float.Invoke(unchecked((Internal_ExpandedFloat_i7t5up*)Args)), 8L, isVolatile: false);
		This->In_use = 0;
	}
}
