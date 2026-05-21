using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_build_error_string
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18build_error_stringEiNS_3cpp4spanIcEE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::build_error_string(int, __llvm_libc_20_1_2_::cpp::span<char>)")]
	public unsafe static Struct_kqhe8i Invoke(int err_num, [MangledName("buffer.coerce0")][NativeType("int")] void* buffer, [MangledName("buffer.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::span<char>")] long buffer_stream)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		details_StringBufferWriterImpl details_StringBufferWriterImpl2 = default(details_StringBufferWriterImpl);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view3) = buffer;
			((long*)(&cpp_string_view3))[1] = buffer_stream;
			if ((ulong)span_char_size.Invoke(&cpp_string_view3) < (ulong)(15L + IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_buffer_size.Invoke()))
			{
				string_view_Constructor.Invoke(&cpp_string_view2, str_195.Pointer);
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
				llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view4);
				span_char_Constructor.Invoke(&cpp_string_view4, span_char_data.Invoke(&cpp_string_view3), span_char_size.Invoke(&cpp_string_view3));
				StringStream_Constructor.Invoke(&details_StringBufferWriterImpl2, &cpp_string_view4);
				llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view4);
				StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(&details_StringBufferWriterImpl2, str_195.Pointer), (sbyte)32), err_num), (sbyte)0);
				Struct_kqhe8i struct_kqhe8i = StringStream_str.Invoke(&details_StringBufferWriterImpl2);
				cpp_string_view* num = &cpp_string_view2;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num = struct_kqhe8i2.field_0;
				byte* num2 = (byte*)(&cpp_string_view2) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num2 = struct_kqhe8i3.field_1;
				llvm_lifetime_end_p0.Invoke(32L, &details_StringBufferWriterImpl2);
			}
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
