using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEEC2El")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::IntegerToString(long)")]
	public unsafe static void Invoke(void* @this, [NativeType("long")] long value)
	{
		details_StringBufferWriterImpl details_StringBufferWriterImpl2 = default(details_StringBufferWriterImpl);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			_ = &((IntegerToString_uuwdyc*)@this)->array;
			((IntegerToString_uuwdyc*)@this)->written = 0L;
			llvm_lifetime_start_p0.Invoke(32L, &details_StringBufferWriterImpl2);
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
			span_char_span_char_21ul_true.Invoke(&cpp_string_view2, &((IntegerToString_uuwdyc*)@this)->array);
			StringBufferWriterImpl_false_Constructor.Invoke(&details_StringBufferWriterImpl2, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			IntegerWriter_write_c69wyf.Invoke(value, &details_StringBufferWriterImpl2);
			((IntegerToString_uuwdyc*)@this)->written = StringBufferWriterImpl_false_size.Invoke(&details_StringBufferWriterImpl2);
			llvm_lifetime_end_p0.Invoke(32L, &details_StringBufferWriterImpl2);
		}
	}
}
