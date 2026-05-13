using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiE9has_valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::has_value() const")]
internal static partial class cpp_expected_LinuxFile_int_has_value_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((cpp_optional_char_OptionalStorage*)@this)->in_use & 1) == 1;
	}
}
