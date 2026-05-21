using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_internal_AbsTimeout_PointerDereference
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEptEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::operator->()")]
	public unsafe static internal_AbsTimeout* Invoke(cpp_optional_59q3zq* @this)
	{
		return unchecked((internal_AbsTimeout*)(&((cpp_optional_r9nbkt*)@this)->storage.field));
	}
}
