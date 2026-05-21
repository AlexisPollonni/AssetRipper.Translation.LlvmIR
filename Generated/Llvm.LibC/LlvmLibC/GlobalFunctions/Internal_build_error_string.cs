using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_build_error_string
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18build_error_stringEiNS_3cpp4spanIcEE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::build_error_string(int, __llvm_libc_20_1_2_::cpp::span<char>)")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("err_num")] int Err_num, [MangledName("buffer.coerce0")][NativeType("int")] void* Buffer, [MangledName("buffer.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::span<char>")] long Buffer_stream)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_details_StringBufferWriterImpl llvm_libc_20_1_2_details_StringBufferWriterImpl = default(Llvm_libc_20_1_2_details_StringBufferWriterImpl);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view3 = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view2) = Buffer;
			((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1] = Buffer_stream;
			if ((ulong)Span_char_size.Invoke(&llvm_libc_20_1_2_cpp_string_view2) < (ulong)(15L + IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_buffer_size.Invoke()))
			{
				String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, Str_195.Pointer);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_details_StringBufferWriterImpl);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_details_StringBufferWriterImpl);
				*(IntPtr*)ptr = unchecked((nint)(-6148914691236517206L));
				((long*)ptr)[1] = -6148914691236517206L;
				((long*)(&llvm_libc_20_1_2_details_StringBufferWriterImpl))[2] = -6148914691236517206L;
				((sbyte*)(&llvm_libc_20_1_2_details_StringBufferWriterImpl))[24] = -86;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_details_StringBufferWriterImpl) + 25;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				ptr2[4] = -86;
				ptr2[5] = -86;
				ptr2[6] = -86;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view3);
				Span_char_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view3, Span_char_data.Invoke(&llvm_libc_20_1_2_cpp_string_view2), Span_char_size.Invoke(&llvm_libc_20_1_2_cpp_string_view2));
				StringStream_Constructor.Invoke(&llvm_libc_20_1_2_details_StringBufferWriterImpl, &llvm_libc_20_1_2_cpp_string_view3);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view3);
				StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(&llvm_libc_20_1_2_details_StringBufferWriterImpl, Str_195.Pointer), (sbyte)32), Err_num), (sbyte)0);
				Struct_kqhe8i struct_kqhe8i = StringStream_str.Invoke(&llvm_libc_20_1_2_details_StringBufferWriterImpl);
				Llvm_libc_20_1_2_cpp_string_view* num = &llvm_libc_20_1_2_cpp_string_view;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num = struct_kqhe8i2.field_0;
				byte* num2 = (byte*)(&llvm_libc_20_1_2_cpp_string_view) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num2 = struct_kqhe8i3.field_1;
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_details_StringBufferWriterImpl);
			}
			return *(Struct_kqhe8i*)(&llvm_libc_20_1_2_cpp_string_view);
		}
	}
}
