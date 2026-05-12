using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEEptEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::operator->()")]
internal static partial class cpp_optional_internal_ExpandedFloat_float_operator
{
	public unsafe static internal_ExpandedFloat_i7t5up* Invoke(cpp_optional_6hseum* @this)
	{
		return unchecked((internal_ExpandedFloat_i7t5up*)(&@this->storage.field));
	}
}
