using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEptEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::operator->()")]
internal static partial class cpp_optional_internal_AbsTimeout_operator
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_7xva92*)@this)->storage.field;
	}
}
