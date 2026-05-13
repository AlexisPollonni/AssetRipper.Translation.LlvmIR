using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEEC2ENS0_9nullopt_tE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
internal static partial class cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t
{
	public unsafe static void Invoke(cpp_optional_q5jaj8* @this)
	{
		cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage_internal_ExpandedFloat_long_double_false_OptionalStorage.Invoke(&@this->storage);
	}
}
