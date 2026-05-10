using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal19build_signal_stringEiNS_3cpp4spanIcEE")]
[DemangledName("__llvm_libc_20_1_2_::internal::build_signal_string(int, __llvm_libc_20_1_2_::cpp::span<char>)")]
internal static partial class internal_build_signal_string_int_cpp_span_char
{
	public unsafe static Struct_kqhe8i Invoke(int sig_num, [MangledName("buffer.coerce0")] void* buffer, [MangledName("buffer.coerce1")] long base_str)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		cpp_string_view cpp_string_view5 = default(cpp_string_view);
		cpp_string_view cpp_string_view6 = default(cpp_string_view);
		details_StringBufferWriterImpl details_StringBufferWriterImpl2 = default(details_StringBufferWriterImpl);
		cpp_string_view cpp_string_view7 = default(cpp_string_view);
		cpp_string_view cpp_string_view8 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view3) = buffer;
			((long*)(&cpp_string_view3))[1] = base_str;
			int num = sig_num;
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view4);
			*(IntPtr*)(&cpp_string_view4) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view4))[1] = -6148914691236517206L;
			cpp_string_view_string_view.Invoke(&cpp_string_view4);
			if (num >= libc_current_sigrtmin.Invoke() && num <= libc_current_sigrtmax.Invoke())
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view5);
				cpp_string_view_string_view_char_const.Invoke(&cpp_string_view5, str_185.Pointer);
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view4, &cpp_string_view5, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view5);
				num = checked(num - libc_current_sigrtmin.Invoke());
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view6);
				cpp_string_view_string_view_char_const.Invoke(&cpp_string_view6, str_1_186.Pointer);
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view4, &cpp_string_view6, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view6);
			}
			if ((ulong)cpp_span_char_size_const.Invoke(&cpp_string_view3) < (ulong)(cpp_string_view_size_const.Invoke(&cpp_string_view4) + 1L + IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_buffer_size.Invoke()))
			{
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &cpp_string_view4, 16L, isVolatile: false);
			}
			else
			{
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
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view7);
				cpp_span_char_span_char_unsigned_long.Invoke(&cpp_string_view7, cpp_span_char_data_const.Invoke(&cpp_string_view3), cpp_span_char_size_const.Invoke(&cpp_string_view3));
				cpp_StringStream_StringStream_cpp_span_char_const.Invoke(&details_StringBufferWriterImpl2, &cpp_string_view7);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view7);
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view8, &cpp_string_view4, 16L, isVolatile: false);
				cpp_StringStream_operator_char.Invoke(cpp_StringStream_cpp_StringStream_operator_int_0_int.Invoke(cpp_StringStream_operator_char.Invoke(cpp_StringStream_operator_cpp_string_view.Invoke(&details_StringBufferWriterImpl2, *(void**)(&cpp_string_view8), ((long*)(&cpp_string_view8))[1]), 32), num), 0);
				Struct_kqhe8i struct_kqhe8i = cpp_StringStream_str_const.Invoke(&details_StringBufferWriterImpl2);
				cpp_string_view* num2 = &cpp_string_view2;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num2 = struct_kqhe8i2.field_0;
				byte* num3 = (byte*)(&cpp_string_view2) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num3 = struct_kqhe8i3.field_1;
				llvm_lifetime_end_p0.Invoke(32L, &details_StringBufferWriterImpl2);
			}
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view4);
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
