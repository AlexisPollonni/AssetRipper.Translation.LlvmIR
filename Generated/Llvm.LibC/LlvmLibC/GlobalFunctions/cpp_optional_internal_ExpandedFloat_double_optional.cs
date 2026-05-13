using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::optional()")]
internal static partial class cpp_optional_internal_ExpandedFloat_double_optional
{
	public unsafe static void Invoke(cpp_optional_vqqfu4* @this)
	{
		cpp_optional_internal_ExpandedFloat_double_OptionalStorage_internal_ExpandedFloat_double_false_OptionalStorage.Invoke(&@this->storage);
	}
}
