using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Writer_get_chars_written
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6Writer17get_chars_writtenEv")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer::get_chars_written()")]
	public unsafe static int Invoke([MangledName("this")] Printf_core_Writer* This)
	{
		return This->Chars_written;
	}
}
