using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer17get_chars_writtenEv")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::get_chars_written()")]
internal static partial class printf_core_Writer_get_chars_written
{
	public unsafe static int Invoke(printf_core_Writer* @this)
	{
		return @this->chars_written;
	}
}
