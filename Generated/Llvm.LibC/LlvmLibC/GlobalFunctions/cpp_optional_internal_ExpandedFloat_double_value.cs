using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIdEEE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>::value() &")]
internal static partial class cpp_optional_internal_ExpandedFloat_double_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_vqqfu4*)@this)->storage.field;
	}
}
