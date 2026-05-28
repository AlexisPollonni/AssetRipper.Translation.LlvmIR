using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Reader_chars_read
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6Reader10chars_readEv")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::chars_read()")]
	public unsafe static long Invoke([MangledName("this")] Scanf_core_Reader* This)
	{
		return This->Cur_chars_read;
	}
}
