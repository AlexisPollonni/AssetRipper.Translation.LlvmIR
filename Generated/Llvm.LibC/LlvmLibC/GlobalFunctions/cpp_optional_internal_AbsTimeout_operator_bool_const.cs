using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEcvbEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::operator bool() const")]
internal static partial class cpp_optional_internal_AbsTimeout_operator_bool_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_7xva92*)@this)->storage.in_use & 1) == 1;
	}
}
