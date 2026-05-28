using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_long_double_Constructor_jkh8ki
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::optional()")]
	[CleanName("Optional_internal_ExpandedFloat_long_double_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Cpp_optional_q5jaj8* This)
	{
		OptionalStorage_internal_ExpandedFloat_long_double_false_Constructor.Invoke(&This->Storage);
	}
}
