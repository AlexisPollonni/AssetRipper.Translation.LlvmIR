using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expected_LinuxFile_int_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::value()")]
	public unsafe static LinuxFile** Invoke(void* @this)
	{
		return unchecked((LinuxFile**)(&((cpp_optional_char_OptionalStorage*)@this)->field));
	}
}
