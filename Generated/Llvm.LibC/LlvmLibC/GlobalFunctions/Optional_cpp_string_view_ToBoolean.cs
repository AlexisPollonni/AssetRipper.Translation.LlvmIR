using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_cpp_string_view_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::operator bool() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Llvm_libc_20_1_2_cpp_optional_bnt67x*)This)->Storage.In_use & 1) == 1;
	}
}
