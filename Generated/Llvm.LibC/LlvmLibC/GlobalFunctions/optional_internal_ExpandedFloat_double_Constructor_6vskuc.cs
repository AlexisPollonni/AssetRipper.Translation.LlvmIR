using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_double_Constructor_6vskuc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::optional()")]
	[CleanName("optional_internal_ExpandedFloat_double_Constructor")]
	public unsafe static void Invoke(cpp_optional_9m4esb* @this)
	{
		OptionalStorage_internal_ExpandedFloat_double_false_Constructor.Invoke(&@this->storage);
	}
}
