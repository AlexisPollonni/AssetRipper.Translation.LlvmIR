using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_cpp_string_view_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS0_11string_viewEEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::string_view>::operator bool() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_bnt67x*)@this)->storage.in_use & 1) == 1;
	}
}
