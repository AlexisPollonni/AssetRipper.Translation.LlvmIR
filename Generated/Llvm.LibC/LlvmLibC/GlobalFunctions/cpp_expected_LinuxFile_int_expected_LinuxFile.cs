using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiEC2ES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::expected(__llvm_libc_20_1_2_::LinuxFile*)")]
internal static partial class cpp_expected_LinuxFile_int_expected_LinuxFile
{
	public unsafe static void Invoke(void* @this, LinuxFile* exp)
	{
		unchecked
		{
			*(LinuxFile**)(&((cpp_optional_char_OptionalStorage*)@this)->field) = exp;
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 1;
		}
	}
}
