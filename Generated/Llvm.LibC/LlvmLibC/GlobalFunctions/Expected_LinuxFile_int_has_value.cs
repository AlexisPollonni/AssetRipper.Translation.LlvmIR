using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_LinuxFile_int_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8expectedIPNS_9LinuxFileEiE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::LinuxFile*, int>::has_value() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Cpp_optional_char_OptionalStorage*)This)->In_use & 1) == 1;
	}
}
