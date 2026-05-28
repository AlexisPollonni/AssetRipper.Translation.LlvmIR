using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_build_signal_string
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal19build_signal_stringEiNS_3cpp4spanIcEE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::build_signal_string(int, __llvm_libc_20_1_2_::cpp::span<char>)")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("sig_num")] int Sig_num, [MangledName("buffer.coerce0")][NativeType("int")] void* Buffer, [MangledName("buffer.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::span<char>")] long Base_str)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Cpp_string_view cpp_string_view2 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view3 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view4 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view5 = default(Cpp_string_view);
		Details_StringBufferWriterImpl details_StringBufferWriterImpl = default(Details_StringBufferWriterImpl);
		Cpp_string_view cpp_string_view6 = default(Cpp_string_view);
		Cpp_string_view cpp_string_view7 = default(Cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = Buffer;
			((long*)(&cpp_string_view2))[1] = Base_str;
			int num = Sig_num;
			Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view3);
			*(IntPtr*)(&cpp_string_view3) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view3))[1] = -6148914691236517206L;
			String_view_Constructor.Invoke(&cpp_string_view3);
			if (num >= Libc_current_sigrtmin.Invoke() && num <= Libc_current_sigrtmax.Invoke())
			{
				Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view4);
				String_view_Constructor.Invoke(&cpp_string_view4, Str_187.Pointer);
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view4, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view4);
				num = checked(num - Libc_current_sigrtmin.Invoke());
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view5);
				String_view_Constructor.Invoke(&cpp_string_view5, Str_1_188.Pointer);
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view3, &cpp_string_view5, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view5);
			}
			if ((ulong)Span_char_size.Invoke(&cpp_string_view2) < (ulong)(String_view_size.Invoke(&cpp_string_view3) + 1L + IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_buffer_size.Invoke()))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view, &cpp_string_view3, 16L, isVolatile: false);
			}
			else
			{
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
				Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view6);
				Span_char_Constructor.Invoke(&cpp_string_view6, Span_char_data.Invoke(&cpp_string_view2), Span_char_size.Invoke(&cpp_string_view2));
				StringStream_Constructor.Invoke(&details_StringBufferWriterImpl, &cpp_string_view6);
				Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view6);
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view7, &cpp_string_view3, 16L, isVolatile: false);
				StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(StringStream_LeftShift.Invoke(&details_StringBufferWriterImpl, *(void**)(&cpp_string_view7), ((long*)(&cpp_string_view7))[1]), (sbyte)32), num), (sbyte)0);
				Struct_kqhe8i struct_kqhe8i = StringStream_str.Invoke(&details_StringBufferWriterImpl);
				Cpp_string_view* num2 = &cpp_string_view;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num2 = struct_kqhe8i2.field_0;
				byte* num3 = (byte*)(&cpp_string_view) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num3 = struct_kqhe8i3.field_1;
				Llvm_lifetime_end_p0.Invoke(32L, &details_StringBufferWriterImpl);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view3);
			return *(Struct_kqhe8i*)(&cpp_string_view);
		}
	}
}
