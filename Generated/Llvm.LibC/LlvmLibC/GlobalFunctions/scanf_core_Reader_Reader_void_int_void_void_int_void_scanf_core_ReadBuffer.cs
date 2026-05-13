using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ReaderC2EPvPFiS2_EPFviS2_EPNS0_10ReadBufferE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::Reader(void*, int (*)(void*), void (*)(int, void*), __llvm_libc_20_1_2_::scanf_core::ReadBuffer*)")]
internal static partial class scanf_core_Reader_Reader_void_int_void_void_int_void_scanf_core_ReadBuffer
{
	public unsafe static void Invoke(scanf_core_Reader* @this, void* stream, void* stream_getc_in, void* stream_ungetc_in, scanf_core_ReadBuffer* stream_buffer)
	{
		@this->rb = stream_buffer;
		@this->input_stream = stream;
		@this->stream_getc = stream_getc_in;
		@this->stream_ungetc = stream_ungetc_in;
		@this->cur_chars_read = 0L;
	}
}
