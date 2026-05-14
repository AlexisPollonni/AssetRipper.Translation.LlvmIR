using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEptEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::operator->()")]
internal static partial class cpp_optional_internal_AbsTimeout_operator
{
	public unsafe static internal_AbsTimeout* Invoke(cpp_optional_59q3zq* @this)
	{
		return unchecked((internal_AbsTimeout*)(&((cpp_optional_r9nbkt*)@this)->storage.field));
	}
}
