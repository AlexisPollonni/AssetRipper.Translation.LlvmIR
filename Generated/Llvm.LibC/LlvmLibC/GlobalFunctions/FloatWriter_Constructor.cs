using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatWriter_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11FloatWriterC2EPNS0_6WriterEbRKNS0_13PaddingWriterE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FloatWriter::FloatWriter(__llvm_libc_20_1_2_::printf_core::Writer*, bool, __llvm_libc_20_1_2_::printf_core::PaddingWriter const&)")]
	public unsafe static void Invoke([MangledName("this")] Printf_core_FloatWriter* This, [MangledName("init_writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_Writer* Init_writer, [MangledName("init_has_decimal_point")][NativeType("bool")] bool Init_has_decimal_point, [MangledName("init_padding_writer")][NativeType("__llvm_libc_20_1_2_::printf_core::PaddingWriter const&")] Printf_core_PaddingWriter* Init_padding_writer)
	{
		sbyte b = (Init_has_decimal_point ? ((sbyte)1) : ((sbyte)0));
		This->Buffered_digits = 0L;
		This->Has_written = 0;
		This->Max_block_count = 0L;
		This->Total_digits = 0L;
		This->Digits_before_decimal = 0L;
		This->Total_digits_written = 0L;
		This->Has_decimal_point = (((b & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
		This->Writer = Init_writer;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Padding_writer, Init_padding_writer, 16L, isVolatile: false);
	}
}
