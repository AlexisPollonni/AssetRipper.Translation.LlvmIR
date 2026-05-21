using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_AbsTimeout_PointerDereference
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEptEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::operator->()")]
	public unsafe static Llvm_libc_20_1_2_internal_AbsTimeout* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_59q3zq* This)
	{
		return unchecked((Llvm_libc_20_1_2_internal_AbsTimeout*)(&((Llvm_libc_20_1_2_cpp_optional_r9nbkt*)This)->Storage.field));
	}
}
