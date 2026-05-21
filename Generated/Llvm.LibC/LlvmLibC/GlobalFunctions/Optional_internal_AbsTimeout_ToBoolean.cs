using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_AbsTimeout_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>::operator bool() const")]
	public unsafe static bool Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_59q3zq* This)
	{
		return (unchecked((Llvm_libc_20_1_2_cpp_optional_r9nbkt*)This)->Storage.In_use & 1) == 1;
	}
}
