using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ReaderC2EPNS0_10ReadBufferE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::Reader(__llvm_libc_20_1_2_::scanf_core::ReadBuffer*)")]
internal static partial class scanf_core_Reader_Reader_scanf_core_ReadBuffer
{
	public unsafe static void Invoke(scanf_core_Reader* @this, scanf_core_ReadBuffer* string_buffer)
	{
		@this->rb = string_buffer;
		@this->input_stream = null;
		@this->stream_getc = null;
		@this->stream_ungetc = null;
		@this->cur_chars_read = 0L;
	}
}
