using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::value()")]
internal static partial class cpp_expected_LinuxFile_int_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_char_OptionalStorage*)@this)->field;
	}
}
