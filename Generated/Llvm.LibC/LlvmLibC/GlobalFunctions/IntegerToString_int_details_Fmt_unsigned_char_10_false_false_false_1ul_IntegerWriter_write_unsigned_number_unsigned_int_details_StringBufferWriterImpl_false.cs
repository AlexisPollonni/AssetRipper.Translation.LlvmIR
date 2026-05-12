using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter21write_unsigned_numberEjRNS1_22StringBufferWriterImplILb0EEE")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::write_unsigned_number(unsigned int, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
internal static partial class IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_write_unsigned_number_unsigned_int_details_StringBufferWriterImpl_false
{
	public unsafe static void Invoke(int value, details_StringBufferWriterImpl* sink)
	{
		sbyte digit = 0;
		int num = value;
		unchecked
		{
			while (details_StringBufferWriterImpl_false_ok_const.Invoke(sink) && num != 0)
			{
				llvm_lifetime_start_p0.Invoke(1L, &digit);
				digit = (sbyte)((uint)num % 10u);
				details_StringBufferWriterImpl_false_push_char.Invoke(sink, IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_digit_char_unsigned_char.Invoke(digit));
				llvm_lifetime_end_p0.Invoke(1L, &digit);
				num = (int)((uint)num / 10u);
			}
		}
	}
}
