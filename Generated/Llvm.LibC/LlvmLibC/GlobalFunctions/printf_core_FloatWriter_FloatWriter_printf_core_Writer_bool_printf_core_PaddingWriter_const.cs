using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriterC2EPNS0_6WriterEbRKNS0_13PaddingWriterE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::FloatWriter(__llvm_libc_20_1_2_::printf_core::Writer*, bool, __llvm_libc_20_1_2_::printf_core::PaddingWriter const&)")]
internal static partial class printf_core_FloatWriter_FloatWriter_printf_core_Writer_bool_printf_core_PaddingWriter_const
{
	public unsafe static void Invoke(void* @this, void* init_writer, bool init_has_decimal_point, void* init_padding_writer)
	{
		sbyte b = (init_has_decimal_point ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			((printf_core_FloatWriter*)@this)->buffered_digits = 0L;
			((printf_core_FloatWriter*)@this)->has_written = 0;
			((printf_core_FloatWriter*)@this)->max_block_count = 0L;
			((printf_core_FloatWriter*)@this)->total_digits = 0L;
			((printf_core_FloatWriter*)@this)->digits_before_decimal = 0L;
			((printf_core_FloatWriter*)@this)->total_digits_written = 0L;
			((printf_core_FloatWriter*)@this)->has_decimal_point = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			((printf_core_FloatWriter*)@this)->writer = init_writer;
			llvm_memcpy_p0_p0_i64.Invoke(&((printf_core_FloatWriter*)@this)->padding_writer, init_padding_writer, 16L, isVolatile: false);
		}
	}
}
