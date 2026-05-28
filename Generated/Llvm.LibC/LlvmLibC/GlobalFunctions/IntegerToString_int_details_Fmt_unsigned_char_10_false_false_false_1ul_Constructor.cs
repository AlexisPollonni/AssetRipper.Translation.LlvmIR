using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEEC2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerToString(int)")]
	public unsafe static void Invoke([MangledName("this")] IntegerToString_bz5c8a* This, [MangledName("value")][NativeType("int")] int Value)
	{
		Details_StringBufferWriterImpl details_StringBufferWriterImpl = default(Details_StringBufferWriterImpl);
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		_ = &This->Array;
		This->Written = 0L;
		Llvm_lifetime_start_p0.Invoke(32L, &details_StringBufferWriterImpl);
		unchecked
		{
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
			Span_char_span_char_11ul_true.Invoke(&cpp_string_view, &This->Array);
			StringBufferWriterImpl_false_Constructor.Invoke(&details_StringBufferWriterImpl, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
			IntegerWriter_write_gqfnqc.Invoke(Value, &details_StringBufferWriterImpl);
			This->Written = StringBufferWriterImpl_false_size.Invoke(&details_StringBufferWriterImpl);
			Llvm_lifetime_end_p0.Invoke(32L, &details_StringBufferWriterImpl);
		}
	}
}
