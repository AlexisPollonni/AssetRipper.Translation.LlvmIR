using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_get_signal_string
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17get_signal_stringEi")]
	[DemangledName("__llvm_libc_20_1_2_::get_signal_string(int)")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("sig_num")][NativeType("int")] int Sig_num)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		Span_char_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view2, Llvm_threadlocal_address_p0.Invoke(Llvm_libc_20_1_2_internal_signal_buffer.Pointer), 29L);
		unchecked
		{
			Struct_kqhe8i struct_kqhe8i = Invoke(Sig_num, *(void**)(&llvm_libc_20_1_2_cpp_string_view2), ((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1]);
			Llvm_libc_20_1_2_cpp_string_view* num = &llvm_libc_20_1_2_cpp_string_view;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num = struct_kqhe8i2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_cpp_string_view) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num2 = struct_kqhe8i3.field_1;
			return *(Struct_kqhe8i*)(&llvm_libc_20_1_2_cpp_string_view);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_17get_signal_stringEiNS_3cpp4spanIcEE")]
	[DemangledName("__llvm_libc_20_1_2_::get_signal_string(int, __llvm_libc_20_1_2_::cpp::span<char>)")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("sig_num")] int Sig_num, [MangledName("buffer.coerce0")][NativeType("int")] void* Buffer, [MangledName("buffer.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::span<char>")] long Opt_str)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_optional_bnt67x llvm_libc_20_1_2_cpp_optional_bnt67x = default(Llvm_libc_20_1_2_cpp_optional_bnt67x);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view3 = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view2) = Buffer;
			((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1] = Opt_str;
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_bnt67x);
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_bnt67x);
			sbyte* ptr2 = ptr;
			*(IntPtr*)ptr2 = unchecked((nint)(-6148914691236517206L));
			((long*)ptr2)[1] = -6148914691236517206L;
			ptr[16] = -86;
			sbyte* ptr3 = ptr + 17;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			ptr3[4] = -86;
			ptr3[5] = -86;
			ptr3[6] = -86;
			MessageMapper_32ul_487ul_get_str.Invoke(&llvm_libc_20_1_2_cpp_optional_bnt67x, (Llvm_libc_20_1_2_MessageMapper_f6bdqy*)Llvm_libc_20_1_2_internal_signal_mapper.Pointer, Sig_num);
			if (Optional_cpp_string_view_ToBoolean.Invoke(&llvm_libc_20_1_2_cpp_optional_bnt67x))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view, Optional_cpp_string_view_Multiply.Invoke(&llvm_libc_20_1_2_cpp_optional_bnt67x), 16L, isVolatile: false);
			}
			else
			{
				Span_char_span_char_true.Invoke(&llvm_libc_20_1_2_cpp_string_view3, &llvm_libc_20_1_2_cpp_string_view2);
				Struct_kqhe8i struct_kqhe8i = Internal_build_signal_string.Invoke(Sig_num, *(void**)(&llvm_libc_20_1_2_cpp_string_view3), ((long*)(&llvm_libc_20_1_2_cpp_string_view3))[1]);
				Llvm_libc_20_1_2_cpp_string_view* num = &llvm_libc_20_1_2_cpp_string_view;
				Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
				*(void**)num = struct_kqhe8i2.field_0;
				byte* num2 = (byte*)(&llvm_libc_20_1_2_cpp_string_view) + 8u;
				Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
				*(long*)num2 = struct_kqhe8i3.field_1;
			}
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_bnt67x);
			return *(Struct_kqhe8i*)(&llvm_libc_20_1_2_cpp_string_view);
		}
	}
}
