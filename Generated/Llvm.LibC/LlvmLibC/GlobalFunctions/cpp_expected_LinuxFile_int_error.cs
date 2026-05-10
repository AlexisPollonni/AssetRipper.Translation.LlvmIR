using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiE5errorEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::error()")]
internal static partial class cpp_expected_LinuxFile_int_error
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_char_OptionalStorage*)@this)->field;
	}
}
