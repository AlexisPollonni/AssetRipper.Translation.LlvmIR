using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEC2ENS0_9nullopt_tE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
internal static partial class cpp_optional_internal_AbsTimeout_optional_cpp_nullopt_t
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_optional_internal_AbsTimeout_OptionalStorage_internal_AbsTimeout_false_OptionalStorage.Invoke(&unchecked((cpp_optional_7xva92*)@this)->storage);
	}
}
