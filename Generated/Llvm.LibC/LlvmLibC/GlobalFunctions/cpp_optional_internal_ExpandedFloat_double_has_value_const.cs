using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEE9has_valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::has_value() const")]
internal static partial class cpp_optional_internal_ExpandedFloat_double_has_value_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_vqqfu4*)@this)->storage.in_use & 1) == 1;
	}
}
