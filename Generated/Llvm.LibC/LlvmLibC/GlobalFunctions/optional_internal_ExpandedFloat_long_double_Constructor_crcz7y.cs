using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_long_double_Constructor_crcz7y
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEEC2EOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::optional(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&&)")]
	[CleanName("optional_internal_ExpandedFloat_long_double_Constructor")]
	public unsafe static void Invoke(cpp_optional_q5jaj8* @this, [NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>&&")] internal_ExpandedFloat_9jummq* t)
	{
		OptionalStorage_internal_ExpandedFloat_long_double_false_OptionalStorage_internal_ExpandedFloat_long_double.Invoke(&@this->storage, cpp_move_internal_ExpandedFloat_long_double.Invoke(t));
		@this->storage.in_use = 1;
	}
}
