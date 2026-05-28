using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEEC2El")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::IntegerToString(long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("long")] long Value)
	{
		Details_StringBufferWriterImpl details_StringBufferWriterImpl = default(Details_StringBufferWriterImpl);
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		unchecked
		{
			_ = &((IntegerToString_uuwdyc*)This)->Array;
			((IntegerToString_uuwdyc*)This)->Written = 0L;
			Llvm_lifetime_start_p0.Invoke(32L, &details_StringBufferWriterImpl);
			sbyte* ptr = (sbyte*)(&details_StringBufferWriterImpl);
			*(IntPtr*)ptr = unchecked((nint)(-6148914691236517206L));
			((long*)ptr)[1] = -6148914691236517206L;
			((long*)(&details_StringBufferWriterImpl))[2] = -6148914691236517206L;
			((sbyte*)(&details_StringBufferWriterImpl))[24] = -86;
			sbyte* ptr2 = (sbyte*)(&details_StringBufferWriterImpl) + 25;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			Span_char_span_char_21ul_true.Invoke(&cpp_string_view, &((IntegerToString_uuwdyc*)This)->Array);
			StringBufferWriterImpl_false_Constructor.Invoke(&details_StringBufferWriterImpl, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
			IntegerWriter_write_c69wyf.Invoke(Value, &details_StringBufferWriterImpl);
			((IntegerToString_uuwdyc*)This)->Written = StringBufferWriterImpl_false_size.Invoke(&details_StringBufferWriterImpl);
			Llvm_lifetime_end_p0.Invoke(32L, &details_StringBufferWriterImpl);
		}
	}
}
