using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriterC2EPNS0_6WriterEbRKNS0_13PaddingWriterE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::FloatWriter(__llvm_libc_20_1_2_::printf_core::Writer*, bool, __llvm_libc_20_1_2_::printf_core::PaddingWriter const&)")]
	public unsafe static void Invoke(printf_core_FloatWriter* @this, [NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] printf_core_Writer* init_writer, [NativeType("bool")] bool init_has_decimal_point, [NativeType("__llvm_libc_20_1_2_::printf_core::PaddingWriter const&")] printf_core_PaddingWriter* init_padding_writer)
	{
		sbyte b = (init_has_decimal_point ? ((sbyte)1) : ((sbyte)0));
		@this->buffered_digits = 0L;
		@this->has_written = 0;
		@this->max_block_count = 0L;
		@this->total_digits = 0L;
		@this->digits_before_decimal = 0L;
		@this->total_digits_written = 0L;
		@this->has_decimal_point = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		@this->writer = init_writer;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->padding_writer, init_padding_writer, 16L, isVolatile: false);
	}
}
