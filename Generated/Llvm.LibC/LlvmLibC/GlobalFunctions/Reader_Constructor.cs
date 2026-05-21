using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Reader_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ReaderC2EPNS0_10ReadBufferE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::Reader(__llvm_libc_20_1_2_::scanf_core::ReadBuffer*)")]
	public unsafe static void Invoke(scanf_core_Reader* @this, [NativeType("__llvm_libc_20_1_2_::scanf_core::ReadBuffer*")] scanf_core_ReadBuffer* string_buffer)
	{
		@this->rb = string_buffer;
		@this->input_stream = null;
		@this->stream_getc = null;
		@this->stream_ungetc = null;
		@this->cur_chars_read = 0L;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ReaderC2EPvPFiS2_EPFviS2_EPNS0_10ReadBufferE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::Reader(void*, int (*)(void*), void (*)(int, void*), __llvm_libc_20_1_2_::scanf_core::ReadBuffer*)")]
	public unsafe static void Invoke(scanf_core_Reader* @this, [NativeType("void*")] void* stream, [NativeType("int (*)(void*)")] void* stream_getc_in, [NativeType("void (*)(int, void*)")] void* stream_ungetc_in, [NativeType("__llvm_libc_20_1_2_::scanf_core::ReadBuffer*")] scanf_core_ReadBuffer* stream_buffer)
	{
		@this->rb = stream_buffer;
		@this->input_stream = stream;
		@this->stream_getc = stream_getc_in;
		@this->stream_ungetc = stream_ungetc_in;
		@this->cur_chars_read = 0L;
	}
}
