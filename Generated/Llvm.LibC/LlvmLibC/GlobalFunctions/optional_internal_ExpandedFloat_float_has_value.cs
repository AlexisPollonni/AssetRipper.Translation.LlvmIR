using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_float_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::has_value() const")]
	public unsafe static bool Invoke(cpp_optional_6hseum* @this)
	{
		return (@this->storage.in_use & 1) == 1;
	}
}
