using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Reader_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ReaderC2EPNS0_10ReadBufferE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::Reader(__llvm_libc_20_1_2_::scanf_core::ReadBuffer*)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_scanf_core_Reader* This, [MangledName("string_buffer")][NativeType("__llvm_libc_20_1_2_::scanf_core::ReadBuffer*")] Llvm_libc_20_1_2_scanf_core_ReadBuffer* String_buffer)
	{
		This->Rb = String_buffer;
		This->Input_stream = null;
		This->Stream_getc = null;
		This->Stream_ungetc = null;
		This->Cur_chars_read = 0L;
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ReaderC2EPvPFiS2_EPFviS2_EPNS0_10ReadBufferE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::Reader(void*, int (*)(void*), void (*)(int, void*), __llvm_libc_20_1_2_::scanf_core::ReadBuffer*)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_scanf_core_Reader* This, [MangledName("stream")][NativeType("void*")] void* Stream, [MangledName("stream_getc_in")][NativeType("int (*)(void*)")] void* Stream_getc_in, [MangledName("stream_ungetc_in")][NativeType("void (*)(int, void*)")] void* Stream_ungetc_in, [MangledName("stream_buffer")][NativeType("__llvm_libc_20_1_2_::scanf_core::ReadBuffer*")] Llvm_libc_20_1_2_scanf_core_ReadBuffer* Stream_buffer)
	{
		This->Rb = Stream_buffer;
		This->Input_stream = Stream;
		This->Stream_getc = Stream_getc_in;
		This->Stream_ungetc = Stream_ungetc_in;
		This->Cur_chars_read = 0L;
	}
}
