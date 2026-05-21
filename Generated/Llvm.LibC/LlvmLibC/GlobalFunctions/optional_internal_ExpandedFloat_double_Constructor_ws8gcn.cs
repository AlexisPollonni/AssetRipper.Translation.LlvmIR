using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_double_Constructor_ws8gcn
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	[CleanName("optional_internal_ExpandedFloat_double_Constructor")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] cpp_optional_9m4esb* @this)
	{
		OptionalStorage_internal_ExpandedFloat_double_false_Constructor.Invoke(&@this->storage);
	}
}
