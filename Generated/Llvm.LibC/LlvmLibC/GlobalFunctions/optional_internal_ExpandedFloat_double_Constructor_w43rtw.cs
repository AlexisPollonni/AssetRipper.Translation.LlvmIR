using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_double_Constructor_w43rtw
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEEC2EOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&&)")]
	[CleanName("optional_internal_ExpandedFloat_double_Constructor")]
	public unsafe static void Invoke(cpp_optional_9m4esb* @this, [NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<double>&&")] internal_ExpandedFloat_k68bhv* t)
	{
		OptionalStorage_internal_ExpandedFloat_double_false_OptionalStorage_internal_ExpandedFloat_double.Invoke(&@this->storage, cpp_move_internal_ExpandedFloat_double.Invoke(t));
		@this->storage.in_use = 1;
	}
}
