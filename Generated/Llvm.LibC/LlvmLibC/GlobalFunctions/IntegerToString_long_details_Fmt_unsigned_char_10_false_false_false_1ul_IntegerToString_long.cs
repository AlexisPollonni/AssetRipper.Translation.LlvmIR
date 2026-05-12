using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEEC2El")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerToString(long)")]
internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerToString_long
{
	public unsafe static void Invoke(IntegerToString_uuwdyc* @this, long value)
	{
		details_StringBufferWriterImpl details_StringBufferWriterImpl2 = default(details_StringBufferWriterImpl);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		_ = &@this->array;
		@this->written = 0L;
		llvm_lifetime_start_p0.Invoke(32L, &details_StringBufferWriterImpl2);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&details_StringBufferWriterImpl2);
			*(IntPtr*)ptr = unchecked((nint)(-6148914691236517206L));
			((long*)ptr)[1] = -6148914691236517206L;
			((long*)(&details_StringBufferWriterImpl2))[2] = -6148914691236517206L;
			((sbyte*)(&details_StringBufferWriterImpl2))[24] = -86;
			sbyte* ptr2 = (sbyte*)(&details_StringBufferWriterImpl2) + 25;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			cpp_span_char_span_char_21ul_true_cpp_array_char_21ul.Invoke(&cpp_string_view2, &@this->array);
			details_StringBufferWriterImpl_false_StringBufferWriterImpl_cpp_span_char.Invoke(&details_StringBufferWriterImpl2, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_write_long_details_StringBufferWriterImpl_false.Invoke(value, &details_StringBufferWriterImpl2);
			@this->written = details_StringBufferWriterImpl_false_size_const.Invoke(&details_StringBufferWriterImpl2);
			llvm_lifetime_end_p0.Invoke(32L, &details_StringBufferWriterImpl2);
		}
	}
}
