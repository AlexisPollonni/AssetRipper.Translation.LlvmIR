using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter5writeElRNS1_22StringBufferWriterImplILb0EEE")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::write(long, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_write_long_details_StringBufferWriterImpl_false
{
	public unsafe static void Invoke(long value, void* sink)
	{
		IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_write_unsigned_number_unsigned_long_details_StringBufferWriterImpl_false.Invoke(IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_abs_long.Invoke(value), sink);
		while (details_StringBufferWriterImpl_false_ok_const.Invoke(sink) && unchecked((ulong)details_StringBufferWriterImpl_false_size_const.Invoke(sink)) < 1uL)
		{
			details_StringBufferWriterImpl_false_push_char.Invoke(sink, 48);
		}
		if (value < 0L)
		{
			details_StringBufferWriterImpl_false_push_char.Invoke(sink, 45);
		}
	}
}
