using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_cpp_array_char_265ul_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::operator bool() const")]
	public unsafe static bool Invoke(cpp_optional_hnriuf* @this)
	{
		return (@this->storage.in_use & 1) == 1;
	}
}
