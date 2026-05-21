using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_AbsTimeout_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] cpp_optional_59q3zq* @this)
	{
		OptionalStorage_internal_AbsTimeout_false_Constructor.Invoke(unchecked((cpp_optional_long_double_OptionalStorage*)(&((cpp_optional_r9nbkt*)@this)->storage)));
	}
}
