using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_long_double_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::has_value() const")]
	public unsafe static bool Invoke(cpp_optional_q5jaj8* @this)
	{
		return (@this->storage.in_use & 1) == 1;
	}
}
