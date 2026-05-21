using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_float_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::value() &")]
	public unsafe static internal_ExpandedFloat_i7t5up* Invoke(cpp_optional_6hseum* @this)
	{
		return unchecked((internal_ExpandedFloat_i7t5up*)(&@this->storage.field));
	}
}
