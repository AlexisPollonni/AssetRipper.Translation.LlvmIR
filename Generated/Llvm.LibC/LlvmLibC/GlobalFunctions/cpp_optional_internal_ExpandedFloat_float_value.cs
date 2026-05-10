using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::value() &")]
internal static partial class cpp_optional_internal_ExpandedFloat_float_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_6hseum*)@this)->storage.field;
	}
}
