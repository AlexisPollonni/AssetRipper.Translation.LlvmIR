using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_float_Constructor_cm37bp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEEC2EOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&)")]
	[CleanName("optional_internal_ExpandedFloat_float_Constructor")]
	public unsafe static void Invoke(cpp_optional_6hseum* @this, [NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>&&")] internal_ExpandedFloat_i7t5up* t)
	{
		OptionalStorage_internal_ExpandedFloat_float_false_OptionalStorage_internal_ExpandedFloat_float.Invoke(&@this->storage, cpp_move_internal_ExpandedFloat_float.Invoke(t));
		@this->storage.in_use = 1;
	}
}
