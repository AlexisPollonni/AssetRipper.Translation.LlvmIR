using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_4File10adjust_bufEv")]
[DemangledName("__llvm_libc_20_1_2_::File::adjust_buf()")]
internal static partial class File_adjust_buf
{
	public unsafe static void Invoke(File_sjnxn4* @this)
	{
		if (File_read_allowed_const.Invoke(@this) && (@this->buf == null || @this->bufsize == 0L))
		{
			@this->buf = &@this->ungetc_buf;
			@this->bufsize = 1L;
			@this->own_buf = 0;
		}
	}
}
