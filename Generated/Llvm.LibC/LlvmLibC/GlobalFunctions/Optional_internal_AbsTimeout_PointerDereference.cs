using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_AbsTimeout_PointerDereference
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEptEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::operator->()")]
	public unsafe static Internal_AbsTimeout* Invoke([MangledName("this")] Cpp_optional_59q3zq* This)
	{
		return unchecked((Internal_AbsTimeout*)(&((Cpp_optional_r9nbkt*)This)->Storage.field));
	}
}
