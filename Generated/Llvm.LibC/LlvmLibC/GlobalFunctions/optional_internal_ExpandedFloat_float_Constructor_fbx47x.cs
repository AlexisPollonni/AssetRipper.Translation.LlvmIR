using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_float_Constructor_fbx47x
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::optional()")]
	[CleanName("optional_internal_ExpandedFloat_float_Constructor")]
	public unsafe static void Invoke(cpp_optional_6hseum* @this)
	{
		OptionalStorage_internal_ExpandedFloat_float_false_Constructor.Invoke(&@this->storage);
	}
}
