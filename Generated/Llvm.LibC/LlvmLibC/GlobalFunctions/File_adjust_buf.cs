using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class File_adjust_buf
{
	[MangledName("_ZN19__llvm_libc_20_1_2_4File10adjust_bufEv")]
	[DemangledName("__llvm_libc_20_1_2_::File::adjust_buf()")]
	public unsafe static void Invoke([MangledName("this")] File_sjnxn4* This)
	{
		if (File_read_allowed.Invoke(This) && (This->Buf == null || This->Bufsize == 0L))
		{
			This->Buf = &This->Ungetc_buf;
			This->Bufsize = 1L;
			This->Own_buf = 0;
		}
	}
}
