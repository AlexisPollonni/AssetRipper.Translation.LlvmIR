using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter21write_unsigned_numberEmRNS1_22StringBufferWriterImplILb0EEE")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::write_unsigned_number(unsigned long, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_write_unsigned_number_unsigned_long_details_StringBufferWriterImpl_false
{
	public unsafe static void Invoke(long value, details_StringBufferWriterImpl* sink)
	{
		sbyte digit = 0;
		long num = value;
		unchecked
		{
			while (details_StringBufferWriterImpl_false_ok_const.Invoke(sink) && num != 0L)
			{
				llvm_lifetime_start_p0.Invoke(1L, &digit);
				digit = (sbyte)((ulong)num % 10uL);
				details_StringBufferWriterImpl_false_push_char.Invoke(sink, IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_digit_char_unsigned_char.Invoke(digit));
				llvm_lifetime_end_p0.Invoke(1L, &digit);
				num = (long)((ulong)num / 10uL);
			}
		}
	}
}
