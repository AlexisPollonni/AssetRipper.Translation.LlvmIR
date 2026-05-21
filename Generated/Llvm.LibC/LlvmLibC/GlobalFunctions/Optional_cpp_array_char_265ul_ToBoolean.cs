using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_cpp_array_char_265ul_ToBoolean
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEEcvbEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::operator bool() const")]
	public unsafe static bool Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_hnriuf* This)
	{
		return (This->Storage.In_use & 1) == 1;
	}
}
