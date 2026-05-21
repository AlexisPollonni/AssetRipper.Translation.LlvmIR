using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_ExpandedFloat_long_double_PointerDereference
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEEptEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::operator->()")]
	public unsafe static internal_ExpandedFloat_9jummq* Invoke(cpp_optional_q5jaj8* @this)
	{
		return unchecked((internal_ExpandedFloat_9jummq*)(&@this->storage.field));
	}
}
